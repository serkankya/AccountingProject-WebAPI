using Microsoft.EntityFrameworkCore;
using Project.Application.Messaging;
using Project.Application.Services.AppServices;

namespace Project.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompanies
{
	public sealed class GetAllCompanyQueryHandler : IQueryHandler<GetAllCompanyQuery, GetAllCompanyQueryResponse>
	{
		readonly ICompanyService _companyService;

		public GetAllCompanyQueryHandler(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public async Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
		{
			var result = _companyService.GetAll();
			return new GetAllCompanyQueryResponse(await result.ToListAsync()); 
		}
	}
}
