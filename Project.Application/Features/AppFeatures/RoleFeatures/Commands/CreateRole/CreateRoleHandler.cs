using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
	public sealed class CreateRoleHandler : IRequestHandler<CreateRoleRequest, CreateRoleResponse>
	{
		readonly RoleManager<AppRole> _roleManager;

		public CreateRoleHandler(RoleManager<AppRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
		{
			AppRole role = await _roleManager.Roles.Where(x=>x.Code == request.Code).FirstOrDefaultAsync();

			if (role != null)
				throw new Exception("This role already exists!");

			role = new AppRole
			{
				Id = Guid.NewGuid().ToString(),
				Code = request.Code,
				Name = request.Name
			};

			await _roleManager.CreateAsync(role);
			return new();
		}
	}
}
