using Project.Domain.Abstract;

namespace Project.Domain.Repositories.GenericRepositories.CompanyDbContext
{
	public interface ICompanyCommandRepository<T> : ICompanyRepository<T>, ICommandGenericRepository<T> where T : EntityBase
	{
	}
}
