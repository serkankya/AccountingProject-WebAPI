using Project.Domain.CompanyEntities;
using Project.Domain.Repositories.CompanyDbContext.UCOARepositories;
using Project.Persistance.Repositories.GenericRepositories.CompanyDbContext;

namespace Project.Persistance.Repositories.CompanyDbContext.UCOARepositories
{
	public sealed class UCOAQueryRepository : CompanyDbQueryRepository<UCOA>, IUCOAQueryRepository
	{
	}
}
