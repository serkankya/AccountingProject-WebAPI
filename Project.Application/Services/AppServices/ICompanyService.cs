using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;

namespace Project.Application.Services.AppServices
{
	public interface ICompanyService
	{
		Task CreateCompany(CreateCompanyRequest request);
	}
}
