using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Application.Abstracts;
using Project.Application.Messaging;
using Project.Domain.MainEntities.Identity;

namespace Project.Application.Features.AppFeatures.AppUserFeatures.LogIn
{
	public class LoginHandler : ICommandHandler<LoginCommand, LoginResponse>
	{
		readonly IJwtProvider _jwtProvider;
		readonly UserManager<AppUser> _userManager;

		public LoginHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
		{
			_jwtProvider = jwtProvider;
			_userManager = userManager;
		}

		public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
		{
			AppUser appUser = await _userManager.Users.Where(x => x.Email == request.EmailOrUsername ||
					x.UserName == request.EmailOrUsername).FirstOrDefaultAsync();

			if (appUser == null)
				throw new Exception("Incorrect username or password.");

			bool checkPassword = await _userManager.CheckPasswordAsync(appUser, request.Password);

			if (checkPassword == false)
				throw new Exception("Incorrect username or password.");

			List<string> roles = new();

			LoginResponse response = new(
				await _jwtProvider.CreateTokenAsync(appUser, roles),
				appUser.Id,
				appUser.Email,
				appUser.FullName);

			return response;
		}
	}
}
