using Project.Domain.MainEntities;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRoles
{
	public sealed record GetAllMainRolesQueryResponse(
		IList<MainRole> MainRoles);
}
