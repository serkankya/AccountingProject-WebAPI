using Project.Domain.Abstract;

namespace Project.Domain.Repositories.GenericRepositories.CompanyDbContext
{
	public interface ICompanyDbCommandRepository<T> : ICompanyDbRepository<T>, ICommandGenericRepository<T> where T : EntityBase
	{
	}
}
