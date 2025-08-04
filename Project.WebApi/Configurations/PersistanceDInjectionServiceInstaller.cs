
using Project.Application.Services.AppServices;
using Project.Application.Services.CompanyServices;
using Project.Domain;
using Project.Domain.Repositories.UCOARepositories;
using Project.Persistance;
using Project.Persistance.Repositories.UCOARepositories;
using Project.Persistance.Services.AppServices;
using Project.Persistance.Services.CompanyServices;

namespace Project.WebApi.Configurations
{
	public class PersistanceDInjectionServiceInstaller : IServiceInstaller
	{
		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<ICompanyService, CompanyService>();
			services.AddScoped<IUCOACommandRepository, UCOACommandRepository>();
			services.AddScoped<IContextService, ContextService>();
			services.AddScoped<IUCOAQueryRepository, UCOAQueryRepository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<IUCOAService, UCOAService>();
		}
	}
}
