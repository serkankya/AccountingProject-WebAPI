using Microsoft.EntityFrameworkCore;
using Project.Domain.Abstract;

namespace Project.Domain.Repositories.GenericRepositories.AppDbContext
{
	public interface IAppCommandRepository<T> : ICommandGenericRepository<T>, IRepository<T> where T : EntityBase 
	{
	}
}
