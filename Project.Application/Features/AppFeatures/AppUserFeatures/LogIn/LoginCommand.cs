using MediatR;
using Project.Application.Messaging;
using System.Windows.Input;

namespace Project.Application.Features.AppFeatures.AppUserFeatures.LogIn
{
	public sealed record LoginCommand
		(string EmailOrUsername,
		string Password) : ICommand<LoginResponse>;
}
