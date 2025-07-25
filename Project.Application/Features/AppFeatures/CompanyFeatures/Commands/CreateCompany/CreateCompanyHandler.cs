using MediatR;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;

namespace Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
	public sealed class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest, CreateCompanyResponse>
	{
		private readonly ICompanyService _companyService;

		public CreateCompanyHandler(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public async Task<CreateCompanyResponse> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
		{
			Company company = await _companyService.CheckMigrationIfExists(request.Name);

			if (company != null)
				throw new Exception("This company name is already exist!");

			await _companyService.CreateCompany(request);
			return new();
		}
	}
}
