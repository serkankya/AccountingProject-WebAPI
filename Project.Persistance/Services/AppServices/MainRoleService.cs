using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;
using Project.Domain.Repositories.AppDbContext.MainRoleRepositories;
using Project.Domain.UnitOfWorks;

namespace Project.Persistance.Services.AppServices
{
	public sealed class MainRoleService : IMainRoleService
	{
		readonly IMainRoleCommandRepository _mainRoleCommandRepository;
		readonly IMainRoleQueryRepository _mainRoleQueryRepository;
		readonly IUnitOfWork _unitOfWork;

		public MainRoleService(IMainRoleCommandRepository mainRoleCommandRepository, IMainRoleQueryRepository mainRoleQueryRepository, IUnitOfWork unitOfWork)
		{
			_mainRoleCommandRepository = mainRoleCommandRepository;
			_mainRoleQueryRepository = mainRoleQueryRepository;
			_unitOfWork = unitOfWork;
		}

		public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
		{
			await _mainRoleCommandRepository.AddAsync(mainRole, cancellationToken);
			await _unitOfWork.SaveChangesAsync(cancellationToken);
		}

		public async Task CreateRangeAsync(List<MainRole> mainRoles, CancellationToken cancellationToken)
		{
			await _mainRoleCommandRepository.AddRangeAsync(mainRoles,cancellationToken);
			await _unitOfWork.SaveChangesAsync(cancellationToken);	
		}

		public async Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken)
		{
			return await _mainRoleQueryRepository.GetFirstByExpression(x => x.Title == title && x.CompanyId == companyId, cancellationToken, false);
		}
	}
}
