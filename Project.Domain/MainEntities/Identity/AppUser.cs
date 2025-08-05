using Microsoft.AspNetCore.Identity;

namespace Project.Domain.MainEntities.Identity
{
	public class AppUser : IdentityUser<string>
	{
		public string FullName { get; set; }
		public string RefreshToken { get; set; }
		public DateTime RefreshTokenExpires { get; set; }
	}
}
