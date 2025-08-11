﻿using Project.Application.Messaging;
using Project.Application.Services.AppServices;

namespace Project.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabases
{
	public sealed class MigrateCompanyDatabasesCommandHandler : ICommandHandler<MigrateCompanyDatabasesCommand, MigrateCompanyDatabasesCommandResponse>
	{
		private readonly ICompanyService _companyService;

		public MigrateCompanyDatabasesCommandHandler(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public async Task<MigrateCompanyDatabasesCommandResponse> Handle(MigrateCompanyDatabasesCommand request, CancellationToken cancellationToken)
		{
			await _companyService.MigrateCompanyDatabases();
			return new();
		}
	}
}
