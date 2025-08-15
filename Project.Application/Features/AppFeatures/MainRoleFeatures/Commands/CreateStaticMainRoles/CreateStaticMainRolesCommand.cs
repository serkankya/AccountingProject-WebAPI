using Project.Application.Messaging;
using Project.Domain.MainEntities;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles
{
	public sealed record CreateStaticMainRolesCommand(List<MainRole> MainRoles) : ICommand<CreateStaticMainRolesCommandResponse>
	{
	}
}
