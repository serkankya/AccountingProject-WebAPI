using MediatR;
using Microsoft.AspNetCore.Identity;
using Project.Application.Abstracts;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.AppUserFeatures.LogIn
{
	public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
	{
		readonly IJwtProvider _jwtProvider;
		readonly UserManager<AppUser> _userManager;

		public LoginHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
		{
			_jwtProvider = jwtProvider;
			_userManager = userManager;
		}

		public Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
