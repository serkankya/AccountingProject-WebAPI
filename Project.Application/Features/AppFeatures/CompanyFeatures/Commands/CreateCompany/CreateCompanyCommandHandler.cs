using MediatR;
using Project.Application.Messaging;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;

namespace Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
	public sealed class CreateCompanyCommandHandler : ICommandHandler<CreateCompanyCommand, CreateCompanyCommandResponse>
	{
		private readonly ICompanyService _companyService;

		public CreateCompanyCommandHandler(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
		{
			Company company = await _companyService.CheckMigrationIfExists(request.Name);

			if (company != null)
				throw new Exception("This company name is already exist!");

			await _companyService.CreateCompany(request);
			return new();
		}
	}
}
