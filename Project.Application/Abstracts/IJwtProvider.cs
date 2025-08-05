using Project.Domain.MainEntities.Identity;

namespace Project.Application.Abstracts
{
	public interface IJwtProvider
	{
		Task<string> CreateToken(AppUser user, List<string> roles);
	}
}
