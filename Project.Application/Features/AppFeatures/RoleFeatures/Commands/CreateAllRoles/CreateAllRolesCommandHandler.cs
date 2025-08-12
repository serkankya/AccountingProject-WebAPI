using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;
using Project.Domain.Roles;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
	public sealed class CreateAllRolesCommandHandler : ICommandHandler<CreateAllRolesCommand, CreateAllRolesCommandResponse>
	{
		readonly IRoleService _roleService;

		public CreateAllRolesCommandHandler(IRoleService roleService)
		{
			_roleService = roleService;
		}

		public async Task<CreateAllRolesCommandResponse> Handle(CreateAllRolesCommand request, CancellationToken cancellationToken)
		{
			IList<AppRole> oldList = RoleList.GetStaticRoles();
			IList<AppRole> newList = new List<AppRole>();

			foreach (var item in oldList)
			{
				AppRole checkRole = await _roleService.GetByCode(item.Code);
				if(checkRole == null)
					newList.Add(item);
			}

			await _roleService.AddRangeAsync(newList);
			return new();
		}
	}
}
