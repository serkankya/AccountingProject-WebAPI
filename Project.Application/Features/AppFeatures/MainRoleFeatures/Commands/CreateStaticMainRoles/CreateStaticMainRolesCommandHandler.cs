using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;
using Project.Domain.Roles;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles
{
	public sealed class CreateStaticMainRolesCommandhandler : ICommandHandler<CreateStaticMainRolesCommand, CreateStaticMainRolesCommandResponse>
	{
		readonly IMainRoleService _mainRoleService;

		public CreateStaticMainRolesCommandhandler(IMainRoleService mainRoleService)
		{
			_mainRoleService = mainRoleService;
		}

		public async Task<CreateStaticMainRolesCommandResponse> Handle(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
		{
			List<MainRole> mainRoles = RoleList.GetStaticMainRoles();
			List<MainRole> newMainRoles = new List<MainRole>();

			foreach (var role in mainRoles)
			{
				MainRole checkMainRole = await _mainRoleService.GetByTitleAndCompanyId(role.Title, role.CompanyId, cancellationToken);

				if (checkMainRole != null)
				{
					newMainRoles.Add(role);
				}
			}

			await _mainRoleService.CreateRangeAsync(newMainRoles, cancellationToken);
			return new();
		}
	}
}
