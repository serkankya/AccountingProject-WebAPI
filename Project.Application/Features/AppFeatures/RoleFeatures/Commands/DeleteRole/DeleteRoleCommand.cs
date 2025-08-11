using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
	public sealed record DeleteRoleCommand(string Id) : ICommand<DeleteRoleCommandResponse>;
}
