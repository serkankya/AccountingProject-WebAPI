using Microsoft.EntityFrameworkCore;

namespace Project.Domain
{
	public interface IUnitOfWork 
	{
		void SetDbContextInstance(DbContext context);
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
