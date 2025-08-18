using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole
{
	public sealed class UpdateMainRoleCommandHandler : ICommandHandler<UpdateMainRoleCommand, UpdateMainRoleCommandResponse>
	{
		readonly IMainRoleService _mainRoleService;

		public UpdateMainRoleCommandHandler(IMainRoleService mainRoleService)
		{
			_mainRoleService = mainRoleService;
		}

		public async Task<UpdateMainRoleCommandResponse> Handle(UpdateMainRoleCommand request, CancellationToken cancellationToken)
		{
			MainRole mainRole = await _mainRoleService.GetById(request.Id);

			if (mainRole == null)
				throw new Exception("This main role could not found.");

			if (mainRole.Title == request.Title)
				throw new Exception("You can not update the same main role.");

			if (mainRole.Title != request.Title)
			{
				MainRole checkTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, mainRole.Id, cancellationToken);

				if (checkTitle != null)
					throw new Exception("This main role already exists!");
			}

			mainRole.Title = request.Title;
			await _mainRoleService.UpdateAsync(mainRole);
			return new();
		}
	}
}
