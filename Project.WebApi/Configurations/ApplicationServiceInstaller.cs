﻿
using Project.Application;

namespace Project.WebApi.Configurations
{
	public class ApplicationServiceInstaller : IServiceInstaller
	{
		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			services.AddMediatR(cfg =>
				cfg.RegisterServicesFromAssembly(typeof(AssemblyReference).Assembly));
		}
	}
}
