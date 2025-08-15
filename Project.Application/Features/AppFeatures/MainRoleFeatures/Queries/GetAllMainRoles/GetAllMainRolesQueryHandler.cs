using Microsoft.EntityFrameworkCore;
using Project.Application.Messaging;
using Project.Application.Services.AppServices;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRoles
{
	public sealed class GetAllMainRolesQueryHandler : IQueryHandler<GetAllMainRolesQuery, GetAllMainRolesQueryResponse>
	{
		readonly IMainRoleService _mainRoleService;

		public GetAllMainRolesQueryHandler(IMainRoleService mainRoleService)
		{
			_mainRoleService = mainRoleService;
		}

		public async Task<GetAllMainRolesQueryResponse> Handle(GetAllMainRolesQuery request, CancellationToken cancellationToken)
		{
			var result = _mainRoleService.GetAllMainRoles();
			return new(await result.ToListAsync());
		}
	}
}
