using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.AppUserFeatures.Commands.LogIn
{
	public sealed record LoginCommand(
		string EmailOrUsername,
		string Password) : ICommand<LoginResponse>;
}
