using MediatR;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
	public sealed class CreateRoleHandler : IRequestHandler<CreateRoleRequest, CreateRoleResponse>
	{
		readonly IRoleService _roleService;

		public CreateRoleHandler(IRoleService roleService)
		{
			_roleService = roleService;
		}

		public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
		{
			AppRole role = await _roleService.GetByCode(request.Code);

			if (role != null)
				throw new Exception("This role already exists!");


			await _roleService.AddAsync(request);
			return new();
		}
	}
}
