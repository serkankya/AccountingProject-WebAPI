using Microsoft.EntityFrameworkCore;
using Project.Domain.UnitOfWorks;
using Project.Persistance.Context;

namespace Project.Persistance.UnitOfWorks
{
	public sealed class CompanyDbUnitOfWork : ICompanyDbUnitOfWork
	{
		private CompanyDbContext _context;
		public void SetDbContextInstance(DbContext context)
		{
			_context = (CompanyDbContext)context;
		}

		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
		{
			int count = await _context.SaveChangesAsync(cancellationToken);
			return count;
		}
	}
}
