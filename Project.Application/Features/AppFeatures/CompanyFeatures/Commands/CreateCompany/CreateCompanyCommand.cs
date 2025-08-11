using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
	public sealed record CreateCompanyCommand(
		string Name,
		string ServerName,
		string DatabaseName,
		string UserId,
		string Password) : ICommand<CreateCompanyCommandResponse>;
}
