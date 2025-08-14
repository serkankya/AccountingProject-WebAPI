using Project.Domain.MainEntities;

namespace Project.Application.Services.AppServices
{
	public interface IMainRoleService
	{
		Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken	cancellationToken);
		Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken);
	}
}
