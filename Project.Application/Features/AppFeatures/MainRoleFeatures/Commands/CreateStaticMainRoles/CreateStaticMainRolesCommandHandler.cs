using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles
{
	public sealed class CreateStaticMainRolesCommandhandler : ICommandHandler<CreateStaticMainRolesCommand, CreateStaticMainRolesCommandResponse>
	{
		public Task<CreateStaticMainRolesCommandResponse> Handle(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
