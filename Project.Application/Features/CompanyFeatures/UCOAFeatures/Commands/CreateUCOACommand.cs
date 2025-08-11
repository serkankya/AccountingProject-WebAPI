using Project.Application.Messaging;

namespace Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands
{
	public sealed record CreateUCOACommand(
		string CompanyId,
		string Code,
		string Name,
		char Type) : ICommand<CreateUCOACommandResponse>;
}
