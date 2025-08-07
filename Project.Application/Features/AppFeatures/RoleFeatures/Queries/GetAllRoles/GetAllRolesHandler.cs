using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
	public sealed class GetAllRolesHandler : IRequestHandler<GetAllRolesRequest, GetAllRolesResponse>
	{
		readonly RoleManager<AppRole> _roleManager;

		public GetAllRolesHandler(RoleManager<AppRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public async Task<GetAllRolesResponse> Handle(GetAllRolesRequest request, CancellationToken cancellationToken)
		{
			IList<AppRole> roles = await _roleManager.Roles.ToListAsync();
			return new GetAllRolesResponse
			{
				Roles = roles
			};
		}
	}
}
