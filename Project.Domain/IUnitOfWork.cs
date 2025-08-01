using Microsoft.EntityFrameworkCore;

namespace Project.Domain
{
	public interface IUnitOfWork 
	{
		void CreateDbContextInstance(DbContext context);
		Task<int> SaveChangesAsync();
	}
}
