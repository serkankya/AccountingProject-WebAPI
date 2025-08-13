using Project.Domain.CompanyEntities;
using Project.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace Project.Domain.Repositories.CompanyDbContext.UCOARepositories
{
	public interface IUCOACommandRepository : ICompanyDbCommandRepository<UCOA>
	{
	}
}
