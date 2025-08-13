using Microsoft.EntityFrameworkCore;
using Project.Domain.Abstract;
using Project.Domain.Repositories.GenericRepositories.CompanyDbContext;
using Project.Persistance.Context;
using System.Linq.Expressions;

namespace Project.Persistance.Repositories.GenericRepositories.CompanyDbContext
{
	public sealed class CompanyQueryRepository<T> : ICompanyQueryRepository<T> where T : EntityBase
	{
		private static readonly Func<Context.CompanyDbContext, string, bool, Task<T>> GetByIdCompiled =
			EF.CompileAsyncQuery((Context.CompanyDbContext context, string id, bool isTracking) => isTracking == true ? context.Set<T>().FirstOrDefault(x => x.Id == id) : context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id));

		private static readonly Func<Context.CompanyDbContext, bool, Task<T>> GetFirstCompiled =
			EF.CompileAsyncQuery((Context.CompanyDbContext context, bool isTracking) => isTracking == true ? context.Set<T>().FirstOrDefault() : context.Set<T>().AsNoTracking().FirstOrDefault());

		private static readonly Func<Context.CompanyDbContext, Expression<Func<T, bool>>, bool, Task<T>> GetFirstByExpressionCompiled =
			EF.CompileAsyncQuery((Context.CompanyDbContext context, Expression<Func<T, bool>> expression, bool isTracking) => isTracking == true ? context.Set<T>().FirstOrDefault(expression) : context.Set<T>().AsNoTracking().FirstOrDefault(expression));

		private Context.CompanyDbContext _context;

		public DbSet<T> Entity { get; set; }

		public void SetDbContextInstance(DbContext context)
		{
			_context = (Context.CompanyDbContext)context;
			Entity = _context.Set<T>();
		}

		public IQueryable<T> GetAll(bool isTracking = true)
		{
			var result = Entity.AsQueryable();

			if (isTracking == false)
				result = result.AsNoTracking();

			return result;
		}

		public async Task<T> GetById(string id, bool isTracking = true)
		{
			return await GetByIdCompiled(_context, id, isTracking);
		}

		public async Task<T> GetFirst(bool isTracking = true)
		{
			return await GetFirstCompiled(_context, isTracking);
		}

		public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, bool isTracking = true)
		{
			return await GetFirstByExpressionCompiled(_context, expression, isTracking);
		}

		public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
		{
			var result = Entity.Where(expression);

			if (isTracking == false)
				result = result.AsNoTracking();

			return result;
		}
	}
}
