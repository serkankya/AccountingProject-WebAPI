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
		readonly IUCOACommandRepository _commandRepository;
		readonly IUCOAQueryRepository _queryRepository;
		readonly IContextService _contextService;
		 CompanyDbContext _companyDbContext;
		readonly IUnitOfWork _unitOfWork;
		readonly IMapper _mapper;

		public UCOAService(IUCOACommandRepository commandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper, IUCOAQueryRepository queryRepository)
		{
			_commandRepository = commandRepository;
			_contextService = contextService;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_queryRepository = queryRepository;
		}

		public async Task CreateUCOAAsync(CreateUCOACommand request, CancellationToken cancellationToken)
		{
			_companyDbContext = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
			_commandRepository.SetDbContextInstance(_companyDbContext);
			_unitOfWork.SetDbContextInstance(_companyDbContext);

			UCOA ucoa =  _mapper.Map<UCOA>(request);
			ucoa.Id = Guid.NewGuid().ToString();

			await _commandRepository.AddAsync(ucoa, cancellationToken);
			await _unitOfWork.SaveChangesAsync(cancellationToken);
		}

		public async Task<UCOA> GetByCode(string code)
		{
			return await _queryRepository.GetFirstByExpression(x => x.Code == code);
		}
	}
}
