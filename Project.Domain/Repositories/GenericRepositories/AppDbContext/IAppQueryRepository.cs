using Project.Domain.Abstract;

namespace Project.Domain.Repositories.GenericRepositories.AppDbContext
{
	public interface IAppQueryRepository<T> : IQueryGenericRepository<T>, IRepository<T> where T : EntityBase
	{
	}
}
