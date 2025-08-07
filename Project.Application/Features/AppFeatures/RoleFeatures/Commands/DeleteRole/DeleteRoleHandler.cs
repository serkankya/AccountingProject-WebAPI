using MediatR;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
	public sealed class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, DeleteRoleResponse>
	{
		readonly IRoleService _roleService;

		public DeleteRoleHandler(IRoleService roleService)
		{
			_roleService = roleService;
		}

		public async Task<DeleteRoleResponse> Handle(DeleteRoleRequest request, CancellationToken cancellationToken)
		{
			AppRole role = await _roleService.GetById(request.Id);

			if (role == null)
				throw new Exception("Role cannot be found.");

			await _roleService.DeleteAsync(role);
			return new();
		}
	}
}
