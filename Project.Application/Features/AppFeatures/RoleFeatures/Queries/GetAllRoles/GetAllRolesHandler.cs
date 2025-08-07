using MediatR;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
	public sealed class GetAllRolesHandler : IRequestHandler<GetAllRolesRequest, GetAllRolesResponse>
	{
		readonly IRoleService _roleService;

		public GetAllRolesHandler(IRoleService roleService)
		{
			_roleService = roleService;
		}

		public async Task<GetAllRolesResponse> Handle(GetAllRolesRequest request, CancellationToken cancellationToken)
		{
			IList<AppRole> roles = await _roleService.GetAllRolesAsync();
			return new GetAllRolesResponse
			{
				Roles = roles
			};
		}
	}
}
