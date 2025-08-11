using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
	public sealed record GetAllRolesQuery() : IQuery<GetAllRolesQueryResponse>;
}
