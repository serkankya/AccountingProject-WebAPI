using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole
{
	public sealed record CreateMainRoleCommand(
		string Title,
		string CompanyId = null) : ICommand<CreateMainRoleCommandResponse>;
}
