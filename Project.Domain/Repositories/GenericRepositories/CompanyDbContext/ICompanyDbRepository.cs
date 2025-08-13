using Microsoft.EntityFrameworkCore;
using Project.Domain.Abstract;

namespace Project.Domain.Repositories.GenericRepositories.CompanyDbContext
{
	public interface ICompanyDbRepository<T> : IRepository<T> where T : EntityBase
	{
		void SetDbContextInstance(DbContext context);
	}
}
