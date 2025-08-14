using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;
using Project.Domain.Roles;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
	public sealed class CreateStaticRolesCommandHandler : ICommandHandler<CreateStaticRolesCommand, CreateStaticRolesCommandResponse>
	{
		readonly IRoleService _roleService;

		public CreateStaticRolesCommandHandler(IRoleService roleService)
		{
			_roleService = roleService;
		}

		public async Task<CreateStaticRolesCommandResponse> Handle(CreateStaticRolesCommand request, CancellationToken cancellationToken)
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
