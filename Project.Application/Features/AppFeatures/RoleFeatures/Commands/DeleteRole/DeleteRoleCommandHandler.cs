using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
	public sealed class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand, DeleteRoleCommandResponse>
	{
		readonly IRoleService _roleService;

		public DeleteRoleCommandHandler(IRoleService roleService)
		{
			_roleService = roleService;
		}

		public async Task<DeleteRoleCommandResponse> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
		{
			AppRole role = await _roleService.GetById(request.Id);

			if (role == null)
				throw new Exception("Role cannot be found.");

			await _roleService.DeleteAsync(role);
			return new();
		}
	}
}
