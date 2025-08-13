using Microsoft.EntityFrameworkCore;

namespace Project.Domain.UnitOfWorks
{
	public interface ICompanyDbUnitOfWork : IUnitOfWork
	{
		void SetDbContextInstance(DbContext context);
	}
}
