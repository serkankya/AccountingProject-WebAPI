using Microsoft.AspNetCore.Identity;

namespace Project.Domain.MainEntities.Identity
{
	public class AppRole : IdentityRole<string>
	{
		public string Code { get; set; }
	}
}
