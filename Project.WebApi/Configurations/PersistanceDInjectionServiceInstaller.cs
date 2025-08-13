using Project.Application.Services.AppServices;
using Project.Application.Services.CompanyServices;
using Project.Domain;
using Project.Domain.Repositories.AppDbContext.CompanyRepositories;
using Project.Domain.Repositories.CompanyDbContext.UCOARepositories;
using Project.Domain.UnitOfWorks;
using Project.Persistance;
using Project.Persistance.Repositories.AppDbContext.CompanyRepositories;
using Project.Persistance.Repositories.CompanyDbContext.UCOARepositories;
using Project.Persistance.Services.AppServices;
using Project.Persistance.Services.CompanyServices;
using Project.Persistance.UnitOfWorks;

namespace Project.WebApi.Configurations
{
	public class PersistanceDInjectionServiceInstaller : IServiceInstaller
	{
		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<ICompanyService, CompanyService>();
			services.AddScoped<IRoleService, RoleService>();
			services.AddScoped<IUCOACommandRepository, UCOACommandRepository>();
			services.AddScoped<IContextService, ContextService>();
			services.AddScoped<IUCOAQueryRepository, UCOAQueryRepository>();
			services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
			services.AddScoped<IUCOAService, UCOAService>();
			services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
			services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
			services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
			services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
		}
	}
}
