using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
	public sealed class GetAllRolesResponse
	{
		public IList<AppRole> Roles { get; set; }
	}
}
