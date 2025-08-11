using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
	public sealed class GetAllRolesQueryHandler : IQueryHandler<GetAllRolesQuery, GetAllRolesQueryResponse>
	{
		readonly IRoleService _roleService;

		public GetAllRolesQueryHandler(IRoleService roleService)
		{
			_roleService = roleService;
		}

		public async Task<GetAllRolesQueryResponse> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
		{
			IList<AppRole> roles = await _roleService.GetAllRolesAsync();
			return new GetAllRolesQueryResponse(roles);
		}
	}
}
