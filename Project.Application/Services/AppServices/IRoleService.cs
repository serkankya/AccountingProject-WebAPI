using Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Services.AppServices
{
	public interface IRoleService
	{
		Task AddAsync(CreateRoleRequest request);
		Task UpdateAsync(AppRole appRole);
		Task DeleteAsync(AppRole appRole);
		Task<IList<AppRole>> GetAllRolesAsync();
		Task<AppRole> GetById(string id);
		Task<AppRole> GetByCode(string code);
	}
}
