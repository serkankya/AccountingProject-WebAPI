using AutoMapper;
using Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands;
using Project.Application.Services.CompanyServices;
using Project.Domain;
using Project.Domain.CompanyEntities;
using Project.Domain.Repositories.UCOARepositories;
using Project.Persistance.Context;

namespace Project.Persistance.Services.CompanyServices
{
	public sealed class UCOAService : IUCOAService
	{
		readonly IUCOACommandRepository _repository;
		readonly IContextService _contextService;
		 CompanyDbContext _companyDbContext;
		readonly IUnitOfWork _unitOfWork;
		readonly IMapper _mapper;

		public UCOAService(IUCOACommandRepository repository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper)
		{
			_repository = repository;
			_contextService = contextService;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task CreateUCOAAsync(CreateUCOARequest request)
		{
			_companyDbContext = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
			_repository.SetDbContextInstance(_companyDbContext);
			_unitOfWork.SetDbContextInstance(_companyDbContext);

			UCOA ucoa =  _mapper.Map<UCOA>(request);
			ucoa.Id = Guid.NewGuid().ToString();

			await _repository.AddAsync(ucoa);
			await _unitOfWork.SaveChangesAsync();
		}
	}
}
