using Project.Domain.MainEntities;
using Project.Domain.Repositories.AppDbContext.CompanyRepositories;
using Project.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Project.Persistance.Repositories.AppDbContext.CompanyRepositories
{
	public sealed class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
	{
		public CompanyCommandRepository(Context.AppDbContext context) : base(context)
		{
		}
	}
}
