using Microsoft.EntityFrameworkCore;
using Project.Domain.Abstract;
using Project.Domain.Repositories.GenericRepositories.AppDbContext;

namespace Project.Persistance.Repositories.GenericRepositories.AppDbContext
{
	public sealed class AppCommandRepository<T> : IAppCommandRepository<T> where T : EntityBase
	{
		private readonly Context.AppDbContext _context;

		public AppCommandRepository(Context.AppDbContext context)
		{
			_context = context;
			Entity = _context.Set<T>();
		}

		public DbSet<T> Entity { get; set; }

		public Task AddAsync(T entity, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public void Remove(T entity)
		{
			throw new NotImplementedException();
		}

		public Task RemoveById(string id)
		{
			throw new NotImplementedException();
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}

		public void Update(T entity)
		{
			throw new NotImplementedException();
		}

		public void UpdateRange(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}
	}
}
