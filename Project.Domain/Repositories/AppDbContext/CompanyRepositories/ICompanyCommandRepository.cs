using Project.Domain.MainEntities;
using Project.Domain.Repositories.GenericRepositories.AppDbContext;

namespace Project.Domain.Repositories.AppDbContext.CompanyRepositories
{
	public interface ICompanyCommandRepository : IAppCommandRepository<Company>
	{
	}
}
