using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
	public sealed record CreateRoleCommand(
		string Code,
		string Name) : ICommand<CreateRoleCommandResponse>;
}
