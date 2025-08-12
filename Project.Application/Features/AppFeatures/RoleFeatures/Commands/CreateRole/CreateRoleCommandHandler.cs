using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
	public sealed class CreateRoleCommandHandler : ICommandHandler<CreateRoleCommand, CreateRoleCommandResponse>
	{
		readonly IRoleService _roleService;

		public CreateRoleCommandHandler(IRoleService roleService)
		{	
			_roleService = roleService;
		}

		public async Task<CreateRoleCommandResponse> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
		{
			AppRole role = await _roleService.GetByCode(request.Code);

			if (role != null)
				throw new Exception("This role already exists!");

			await _roleService.AddAsync(request);
			return new();
		}
	}
}
