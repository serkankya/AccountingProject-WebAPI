using FluentValidation;
using MediatR;
using Project.Application;
using Project.Application.Behavior;

namespace Project.WebApi.Configurations
{
	public class ApplicationServiceInstaller : IServiceInstaller
	{
		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			services.AddMediatR(cfg =>
				cfg.RegisterServicesFromAssembly(typeof(AssemblyReference).Assembly));

			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

			services.AddValidatorsFromAssembly(typeof(AssemblyReference).Assembly);
		}
	}
}
