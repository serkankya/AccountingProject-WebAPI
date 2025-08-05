
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Project.WebApi.OptionsSetup;

namespace Project.WebApi.Configurations
{
	public class AuthenticationAuthorization : IServiceInstaller
	{
		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			services.ConfigureOptions<JwtOptionsSetup>();

			services.ConfigureOptions<JwtBearerOptionsSetup>();

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
		}
	}
}
