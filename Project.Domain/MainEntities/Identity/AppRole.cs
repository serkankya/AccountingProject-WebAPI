using Microsoft.AspNetCore.Identity;

namespace Project.Domain.MainEntities.Identity
{
	public sealed class AppRole : IdentityRole<string>
	{
		public AppRole()
		{
			Id = Guid.NewGuid().ToString();
		}

		public AppRole(string title, string code, string name)
		{
			Id = Guid.NewGuid().ToString();
			Title = title;
			Code = code;
			Name = name;
		}

		public string Code { get; set; }
		public string Title { get; set; }
	}
}
