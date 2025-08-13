using Project.Domain.CompanyEntities;
using Project.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace Project.Domain.Repositories.UCOARepositories
{
	public interface IUCOACommandRepository : ICompanyCommandRepository<UCOA>
	{
	}
}
