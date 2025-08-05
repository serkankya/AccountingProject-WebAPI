using MediatR;

namespace Project.Application.Features.AppFeatures.AppUserFeatures.LogIn
{
	public sealed class LoginRequest: IRequest<LoginResponse>
	{
		public string EmailOrUsername { get; set; }
		public string Password { get; set; }
	}
}
