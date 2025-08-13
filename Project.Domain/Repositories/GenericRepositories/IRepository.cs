using Microsoft.EntityFrameworkCore;
using Project.Domain.Abstract;

namespace Project.Domain.Repositories.GenericRepositories
{
	public interface IRepository<T> where T : EntityBase
	{
		public DbSet<T> Entity { get; set; }
	}
}
