using Project.Domain.MainEntities;
using Project.Domain.Repositories.AppDbContext.MainRoleRepositories;
using Project.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Project.Persistance.Repositories.AppDbContext.MainRoleRepositories
{
	public sealed class MainRoleQueryRepository : AppQueryRepository<MainRole>, IMainRoleQueryRepository
	{
		public MainRoleQueryRepository(Context.AppDbContext context) : base(context)
		{
		}
	}
}
