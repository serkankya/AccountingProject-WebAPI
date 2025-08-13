using Project.Domain.MainEntities;
using Project.Domain.Repositories.AppDbContext.CompanyRepositories;
using Project.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Project.Persistance.Repositories.AppDbContext.CompanyRepositories
{
	public sealed class CompanyQueryRepository : AppQueryRepository<Company>, ICompanyQueryRepository
	{
		public CompanyQueryRepository(Context.AppDbContext context) : base(context)
		{
		}
	}
}
