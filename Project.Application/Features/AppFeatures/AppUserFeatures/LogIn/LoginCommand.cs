using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.AppUserFeatures.LogIn
{
	public sealed record LoginCommand(
		string EmailOrUsername,
		string Password) : ICommand<LoginResponse>;
}
