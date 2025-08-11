using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Domain.MainEntities;

namespace Project.Application.Services.AppServices
{
	public interface ICompanyService
	{
		Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken);
		Task<Company?> CheckMigrationIfExists(string name);
		Task MigrateCompanyDatabases();
	}
}
