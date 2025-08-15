using Project.Application.Messaging;
using Project.Application.Services.AppServices;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole
{
	public sealed class RemoveByIdMainRoleCommandHandler : ICommandHandler<RemoveByIdMainRoleCommand, RemoveByIdMainRoleCommandResponse>
	{
		readonly IMainRoleService _mainRoleService;

		public RemoveByIdMainRoleCommandHandler(IMainRoleService mainRoleService)
		{
			_mainRoleService = mainRoleService;
		}

		public async Task<RemoveByIdMainRoleCommandResponse> Handle(RemoveByIdMainRoleCommand request, CancellationToken cancellationToken)
		{
			await _mainRoleService.RemoveById(request.Id);
			return new(); 
		}
	}
}
