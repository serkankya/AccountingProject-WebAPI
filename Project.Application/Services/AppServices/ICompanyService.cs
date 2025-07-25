using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Domain.MainEntities;

namespace Project.Application.Services.AppServices
{
	public interface ICompanyService
	{
		Task CreateCompany(CreateCompanyRequest request);
		Task<Company?> CheckMigrationIfExists(string name);
		Task MigrateCompanyDatabases();
	}
}
