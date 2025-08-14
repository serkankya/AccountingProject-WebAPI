using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole
{
	public sealed class CreateMainRoleCommandHandler : ICommandHandler<CreateMainRoleCommand, CreateMainRoleCommandResponse>
	{
		readonly IMainRoleService _mainRoleService;

		public CreateMainRoleCommandHandler(IMainRoleService mainRoleService)
		{
			_mainRoleService = mainRoleService;
		}

		public async Task<CreateMainRoleCommandResponse> Handle(CreateMainRoleCommand request, CancellationToken cancellationToken)
		{
			MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, request.CompanyId);

			if(checkMainRoleTitle != null)
				throw new Exception("This role already exists!");

			MainRole mainRole = new(
				id: Guid.NewGuid().ToString(),
				title: request.Title,
				isRoleCreatedByAdmin: request.IsRoleCreatedByAdmin,
				companyId: request.CompanyId
				);

			await _mainRoleService.CreateAsync(MainRole);

			return new(); 
		}
	}
}
