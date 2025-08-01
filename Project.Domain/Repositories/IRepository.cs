using Microsoft.EntityFrameworkCore;
using Project.Domain.Abstract;

namespace Project.Domain.Repositories
{
	public interface IRepository<T> where T : EntityBase
	{
		void SetDbContextInstance(DbContext context);
		DbSet<T> Entity { get; set; }
	}
}
