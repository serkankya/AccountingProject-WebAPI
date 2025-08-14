using Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
	public sealed record CreateStaticRolesCommand() : ICommand<CreateStaticRolesCommandResponse>
	{
	}
}
