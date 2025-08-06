namespace Project.Application.Features.AppFeatures.AppUserFeatures.LogIn
{
	public sealed class LoginResponse
	{
		public string Token { get; set; }
		public string UserId { get; set; }
		public string EmailOrUsername { get; set; }
		public string FullName { get; set; }
	}
}
