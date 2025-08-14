using Project.Domain.MainEntities;
using Project.Domain.Repositories.AppDbContext.MainRoleRepositories;
using Project.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Project.Persistance.Repositories.AppDbContext.MainRoleRepositories
{
	public sealed class MainRoleCommandRepository : AppCommandRepository<MainRole>, IMainRoleCommandRepository
	{
		public MainRoleCommandRepository(Context.AppDbContext context) : base(context)
		{
		}
	}
}
