using Project.Domain.Abstract;

namespace Project.Domain.Repositories.GenericRepositories.CompanyDbContext
{
	public interface ICompanyDbQueryRepository<T> : ICompanyDbRepository<T>, IQueryGenericRepository<T> where T : EntityBase
	{
	}
}
