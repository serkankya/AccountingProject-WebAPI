using Project.Domain.MainEntities;

namespace Project.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompanies
{
	public sealed record GetAllCompanyQueryResponse(List<Company> Companies);
}
