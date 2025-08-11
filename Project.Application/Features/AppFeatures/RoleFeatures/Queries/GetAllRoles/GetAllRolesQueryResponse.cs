using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
	public sealed record GetAllRolesQueryResponse(IList<AppRole> Roles);
}
