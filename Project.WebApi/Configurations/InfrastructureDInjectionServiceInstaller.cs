using Project.Application.Abstracts;
using Project.Infrastructure.Authentication;

namespace Project.WebApi.Configurations
{
	public class InfrastructureDInjectionServiceInstaller : IServiceInstaller
	{
		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IJwtProvider, JwtProvider>();
		}
	}
}
