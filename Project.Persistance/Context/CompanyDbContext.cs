using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Project.Domain.Abstract;
using Project.Domain.MainEntities;

namespace Project.Persistance.Context
{
	public sealed class CompanyDbContext : DbContext
	{
		private string ConnectionString = "";

		public CompanyDbContext(Company company = null)
		{
			if (company != null)
			{
				if (company.Id == "")
					ConnectionString =
						$"Data Source={company.ServerName};" +
						$"Initial Catalog = {company.DatabaseName}; " +
						$"User Id = {company.ServerUserId}; " +
						$"Password = {company.ServerPassword}; " +
						$"Integrated Security=True;" +
						$"Connect Timeout=30;" +
						$"Encrypt=False;" +
						$"Trust Server Certificate=False;" +
						$"Application Intent=ReadWrite;" +
						$"Multi Subnet Failover=False";
				else
					ConnectionString =
						$"Data Source={company.ServerName};" +
						$"Initial Catalog = {company.DatabaseName}; " +
						$"Integrated Security=True;" +
						$"Connect Timeout=30;" +
						$"Encrypt=False;" +
						$"Trust Server Certificate=False;" +
						$"Application Intent=ReadWrite;" +
						$"Multi Subnet Failover=False";
			}
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(ConnectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) =>
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			var entries = ChangeTracker.Entries<EntityBase>();

			foreach (var item in entries)
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
	}

	public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
	{
		public CompanyDbContext CreateDbContext(string[] args)
		{
			return new CompanyDbContext();
		}
	}
}
