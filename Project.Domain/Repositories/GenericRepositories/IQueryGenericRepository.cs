using Project.Domain.Abstract;
using System.Linq.Expressions;

namespace Project.Domain.Repositories.GenericRepositories
{
	public interface IQueryGenericRepository<T> where T : EntityBase
	{
		IQueryable<T> GetAll(bool isTracking = true);
		IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true);
		Task<T> GetById(string id, bool isTracking = true);
		Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, CancellationToken cancellationToken, bool isTracking = true);
		Task<T> GetFirst(bool isTracking = true);
	}
}
