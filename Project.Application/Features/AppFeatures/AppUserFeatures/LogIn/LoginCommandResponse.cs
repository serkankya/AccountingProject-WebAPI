namespace Project.Application.Features.AppFeatures.AppUserFeatures.LogIn
{
	public sealed record LoginResponse
		(string Token,
		string UserId,
		string EmailOrUsername,
		string FullName);
}
