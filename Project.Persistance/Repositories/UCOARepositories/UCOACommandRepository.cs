using Project.Domain.CompanyEntities;
using Project.Domain.Repositories.UCOARepositories;
using Project.Persistance.Repositories.GenericRepositories.CompanyDbContext;

namespace Project.Persistance.Repositories.UCOARepositories
{
	public sealed class UCOACommandRepository : CompanyCommandRepository<UCOA>, IUCOACommandRepository
	{
	}
}
