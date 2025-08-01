using Microsoft.EntityFrameworkCore;
using Project.Domain;
using Project.Domain.MainEntities;
using Project.Persistance.Context;

namespace Project.Persistance
{
	public sealed class ContextService : IContextService
	{
		readonly AppDbContext _appDbContext;

		public ContextService(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public DbContext CreateDbContextInstance(string companyId)
		{
			Company company = _appDbContext.Set<Company>().Find(companyId);
			return new CompanyDbContext(company);
		}
	}
}
