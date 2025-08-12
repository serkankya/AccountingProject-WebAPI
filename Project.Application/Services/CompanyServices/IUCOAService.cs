using Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands;
using Project.Domain.CompanyEntities;

namespace Project.Application.Services.CompanyServices
{
	public interface IUCOAService
	{
		Task CreateUCOAAsync(CreateUCOACommand request, CancellationToken cancellationToken);
		Task<UCOA> GetByCode(string code);	
	}
}
