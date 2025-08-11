using Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands;

namespace Project.Application.Services.CompanyServices
{
	public interface IUCOAService
	{
		Task CreateUCOAAsync(CreateUCOACommand request);
	}
}
