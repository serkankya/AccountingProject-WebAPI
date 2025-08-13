using Project.Domain.Abstract;

namespace Project.Domain.Repositories.GenericRepositories.CompanyDbContext
{
	public interface ICompanyQueryRepository<T> : ICompanyRepository<T>, IQueryGenericRepository<T> where T : EntityBase
	{
	}
}
