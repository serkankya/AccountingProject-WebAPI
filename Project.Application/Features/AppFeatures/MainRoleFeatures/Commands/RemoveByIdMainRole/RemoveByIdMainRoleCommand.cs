using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole
{
	public sealed record RemoveByIdMainRoleCommand(
		string Id) : ICommand<RemoveByIdMainRoleCommandResponse>;
}
