using Project.Domain.MainEntities.Identity;

namespace Project.Application.Abstracts
{
	public interface IJwtProvider
	{
		Task<string> CreateTokenAsync(AppUser user, List<string> roles);
	}
}
