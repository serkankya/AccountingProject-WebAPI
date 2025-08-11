using Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Services.AppServices
{
	public interface IRoleService
	{
		Task AddAsync(CreateRoleCommand request);
		Task UpdateAsync(AppRole appRole);
		Task DeleteAsync(AppRole appRole);
		Task<IList<AppRole>> GetAllRolesAsync();
		Task<AppRole> GetById(string id);
		Task<AppRole> GetByCode(string code);
	}
}
