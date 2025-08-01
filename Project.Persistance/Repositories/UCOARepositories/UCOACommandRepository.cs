using Project.Domain.CompanyEntities;
using Project.Domain.Repositories.UCOARepositories;

namespace Project.Persistance.Repositories.UCOARepositories
{
	public sealed class UCOACommandRepository : CommandRepository<UCOA>, IUCOACommandRepository
	{
	}
}
