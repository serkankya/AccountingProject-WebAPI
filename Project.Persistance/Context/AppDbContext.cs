using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Project.Domain.Abstract;
using Project.Domain.MainEntities;
using Project.Domain.MainEntities.Identity;
using System.Globalization;

namespace Project.Persistance.Context
{
	public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Company> Companies { get; set; }
		public DbSet<UserCompany> UserCompanies { get; set; }

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			var entities = ChangeTracker.Entries<EntityBase>();

			foreach (var item in entities)
			{
				if (item.State == EntityState.Added)
				{
					item.Property(x => x.CreatedAt).CurrentValue = DateTime.Now;
				}

				if (item.State == EntityState.Modified)
				{
					item.Property(x => x.UpdatedAt).CurrentValue = DateTime.Now;
				}
			}

			return base.SaveChangesAsync(cancellationToken);
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Ignore<IdentityRoleClaim<string>>();
			builder.Ignore<IdentityUserClaim<string>>();
			builder.Ignore<IdentityUserLogin<string>>();
			builder.Ignore<IdentityUserRole<string>>();
			builder.Ignore<IdentityUserToken<string>>();
		}
	}

	public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
	{
		public AppDbContext CreateDbContext(string[] args)
		{
			var optBuilder = new DbContextOptionsBuilder();

			var connString = "Data Source=SERKANKAYA;Initial Catalog = MasterAccountingDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

			optBuilder.UseSqlServer(connString);

			return new AppDbContext(optBuilder.Options);
		}
	}
}
