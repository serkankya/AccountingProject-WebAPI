using MediatR;
using Microsoft.AspNetCore.Identity;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
	public sealed class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, DeleteRoleResponse>
	{
		readonly RoleManager<AppRole> _roleManager;

		public DeleteRoleHandler(RoleManager<AppRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public async Task<DeleteRoleResponse> Handle(DeleteRoleRequest request, CancellationToken cancellationToken)
		{
			AppRole role = await _roleManager.FindByIdAsync(request.Id);

			if (role == null)
				throw new Exception("Role cannot be found.");

			await _roleManager.DeleteAsync(role);
			return new();
		}
	}
}
