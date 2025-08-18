using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;
using Project.Domain.Repositories.AppDbContext.MainRoleRepositories;
using Project.Domain.UnitOfWorks;
using System.Threading.Tasks;

namespace Project.Persistance.Services.AppServices
{
	public sealed class MainRoleService : IMainRoleService
	{
		readonly IMainRoleCommandRepository _mainRoleCommandRepository;
		readonly IMainRoleQueryRepository _mainRoleQueryRepository;
		readonly IAppUnitOfWork _appUnitOfWork;

		public MainRoleService(IMainRoleCommandRepository mainRoleCommandRepository, IMainRoleQueryRepository mainRoleQueryRepository, IAppUnitOfWork appUnitOfWork)
		{
			_mainRoleCommandRepository = mainRoleCommandRepository;
			_mainRoleQueryRepository = mainRoleQueryRepository;
			_appUnitOfWork = appUnitOfWork;
		}

		public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
		{
			await _mainRoleCommandRepository.AddAsync(mainRole, cancellationToken);
			await _appUnitOfWork.SaveChangesAsync(cancellationToken);
		}

		public async Task CreateRangeAsync(List<MainRole> mainRoles, CancellationToken cancellationToken)
		{
			await _mainRoleCommandRepository.AddRangeAsync(mainRoles,cancellationToken);
			await _appUnitOfWork.SaveChangesAsync(cancellationToken);	
		}

		public IQueryable<MainRole> GetAllMainRoles()
		{
			return _mainRoleQueryRepository.GetAll();
		}

		public async Task<MainRole> GetById(string Id)
		{
			return await _mainRoleQueryRepository.GetById(Id);	
		}

		public async Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken)
		{
			return await _mainRoleQueryRepository.GetFirstByExpression(x => x.Title == title && x.CompanyId == companyId, cancellationToken, false);
		}

		public async Task RemoveById(string Id)
		{
			await _mainRoleCommandRepository.RemoveById(Id);
			await _appUnitOfWork.SaveChangesAsync();
		}

		public async Task UpdateAsync(MainRole mainRole)
		{
			_mainRoleCommandRepository.Update(mainRole);
			await _appUnitOfWork.SaveChangesAsync();
		}
	}
}
