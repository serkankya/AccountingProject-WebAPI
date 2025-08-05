using Project.Application.Abstracts;
using Project.Domain.MainEntities.Identity;

namespace Project.Infrastructure.Authentication
{
	public sealed class JwtProvider : IJwtProvider
	{
		public async Task<string> CreateToken(AppUser user, List<string> roles)
		{
			return null;
		}
	}
}
