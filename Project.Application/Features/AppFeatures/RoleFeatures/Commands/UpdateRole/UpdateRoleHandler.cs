using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
	public sealed class UpdateRoleHandler : IRequestHandler<UpdateRoleRequest, UpdateRoleResponse>
	{
		readonly RoleManager<AppRole> _roleManager;

		public UpdateRoleHandler(RoleManager<AppRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public async Task<UpdateRoleResponse> Handle(UpdateRoleRequest request, CancellationToken cancellationToken)
		{
			AppRole role = await _roleManager.FindByIdAsync(request.Id);

			if (role == null)
				throw new Exception("Role cannot be found.");

			if (role.Code != request.Code)
			{
				AppRole code = await _roleManager.Roles.FirstOrDefaultAsync(x=>x.Code == request.Code);

				if (code != null)
					throw new Exception("This code already exists!");
			}

			role.Code = request.Code;
			role.Name = request.Name;

			await _roleManager.UpdateAsync(role);
			return new();
		}
	}
}
