using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;
using Project.Domain.Repositories.AppDbContext.CompanyRepositories;
using Project.Domain.UnitOfWorks;
using Project.Persistance.Context;

namespace Project.Persistance.Services.AppServices
{
	public sealed class CompanyService : ICompanyService
	{
		readonly ICompanyCommandRepository _companyCommandRepository;
		readonly ICompanyQueryRepository _companyQueryRepository;
		readonly IAppUnitOfWork _appUnitOfWork;
		readonly IMapper _mapper;

		public CompanyService(IMapper mapper, ICompanyCommandRepository companyCommandRepository, ICompanyQueryRepository companyQueryRepository, IAppUnitOfWork appUnitOfWork)
		{
			_mapper = mapper;
			_companyCommandRepository = companyCommandRepository;
			_companyQueryRepository = companyQueryRepository;
			_appUnitOfWork = appUnitOfWork;
		}

		public async Task<Company?> CheckMigrationIfExists(string name, CancellationToken cancellationToken)
		{
			return await _companyQueryRepository.GetFirstByExpression(x => x.Name == name, cancellationToken, false);
		}

		public async Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
		{
			Company company = _mapper.Map<Company>(request);
			company.Id = Guid.NewGuid().ToString();
			await _companyCommandRepository.AddAsync(company, cancellationToken);
			await _appUnitOfWork.SaveChangesAsync(cancellationToken);
		}

		public IQueryable<Company> GetAll()
		{
			return _companyQueryRepository.GetAll();
		}

		public async Task MigrateCompanyDatabases()
		{
			var companies = await _companyQueryRepository.GetAll().ToListAsync();

			foreach (var item in companies)
			{
				var database = new CompanyDbContext(item);
				database.Database.Migrate();
			}
		}
	}
}
