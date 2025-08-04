
using Microsoft.EntityFrameworkCore;
using Project.Domain.MainEntities.Identity;
using Project.Persistance;
using Project.Persistance.Context;

namespace Project.WebApi.Configurations
{
	public class PersistanceServiceInstaller : IServiceInstaller
	{
		private const string ServerName = "SqlServerConnection";

		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(opt =>
					opt.UseSqlServer(configuration.GetConnectionString(ServerName)));

			services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

			services.AddAutoMapper(typeof(AssemblyReference).Assembly);
		}
	}
}
