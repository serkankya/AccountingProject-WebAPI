using Project.Application.Messaging;
using System.Windows.Input;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole
{
	public sealed record UpdateMainRoleCommand(
		string Id,
		string Title) : ICommand<UpdateMainRoleCommandResponse>;
}
