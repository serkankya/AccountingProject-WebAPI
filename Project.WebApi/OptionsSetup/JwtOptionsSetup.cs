using Microsoft.Extensions.Options;
using Project.Infrastructure.Authentication;

namespace Project.WebApi.OptionsSetup
{
	public sealed class JwtOptionsSetup : IConfigureOptions<JwtOptions>
	{
		const string JwtOption = nameof(JwtOption);
		readonly IConfiguration _configuration;

		public JwtOptionsSetup(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public void Configure(JwtOptions options)
		{
			_configuration.GetSection(JwtOption).Bind(options);
		}
	}
}
