using MediatR;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
	public sealed class UpdateRoleHandler : IRequestHandler<UpdateRoleRequest, UpdateRoleResponse>
	{
		readonly IRoleService _roleService;

		public UpdateRoleHandler(IRoleService roleService)
		{
			_roleService = roleService;
		}

		public async Task<UpdateRoleResponse> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
		{
			AppRole role = await _roleService.GetById(request.Id);

			if (role == null)
				throw new Exception("Role cannot be found.");

			if (role.Code != request.Code)
			{
				AppRole code = await _roleService.GetByCode(request.Code);

				if (code != null)
					throw new Exception("This code already exists!");
			}

			role.Code = request.Code;
			role.Name = request.Name;

			await _roleService.UpdateAsync(role);
			return new();
		}
	}
}
