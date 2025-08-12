namespace Project.Application.Features.AppFeatures.AppUserFeatures.Commands.LogIn
{
	public sealed record LoginResponse
		(string Token,
		string UserId,
		string EmailOrUsername,
		string FullName);
}
