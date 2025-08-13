using Microsoft.EntityFrameworkCore;
using Project.Domain.Abstract;
using Project.Domain.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Persistance.Repositories.GenericRepositories.AppDbContext
{
	public sealed class AppQueryRepository<T> : IAppQueryRepository<T> where T : EntityBase
	{
		private readonly Context.AppDbContext _context;

		public AppQueryRepository(Context.AppDbContext context)
		{
			_context = context;
			Entity = _context.Set<T>();
		}

		public DbSet<T> Entity { get; set; }

		public IQueryable<T> GetAll(bool isTracking = true)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetById(string id, bool isTracking = true)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetFirst(bool isTracking = true)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetFirstByExpression(System.Linq.Expressions.Expression<Func<T, bool>> expression, bool isTracking = true)
		{
			throw new NotImplementedException();
		}

		public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> expression, bool isTracking = true)
		{
			throw new NotImplementedException();
		}
	}
}
