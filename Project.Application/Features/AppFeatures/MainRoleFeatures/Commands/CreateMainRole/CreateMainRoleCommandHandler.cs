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
			MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, request.CompanyId, cancellationToken);

			if (checkMainRoleTitle != null)
				throw new Exception("This role already exists!");

			MainRole mainRole = new(
				id: Guid.NewGuid().ToString(),
				title: request.Title,
				isRoleCreatedByAdmin: request.CompanyId != null ? false : true,
				companyId: request.CompanyId
				);

			await _mainRoleService.CreateAsync(mainRole, cancellationToken);

			return new();
		}
	}
}
