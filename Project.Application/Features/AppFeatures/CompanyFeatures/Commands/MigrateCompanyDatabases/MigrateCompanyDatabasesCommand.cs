using Project.Application.Messaging;

namespace Project.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabases
{
	public sealed record MigrateCompanyDatabasesCommand() : ICommand<MigrateCompanyDatabasesCommandResponse>;
}
