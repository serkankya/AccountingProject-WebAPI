using Project.Domain.Abstract;
using System.Linq.Expressions;

namespace Project.Domain.Repositories
{
	public interface IQueryRepository<T> : IRepository<T> where T : EntityBase
	{
		IQueryable<T> GetAll();
		IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
		Task<T> GetById(string id);
		Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression);
		Task<T> GetFirst();
	}
}
