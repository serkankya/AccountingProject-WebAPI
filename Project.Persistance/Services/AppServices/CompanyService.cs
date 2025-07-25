using AutoMapper;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;
using Project.Persistance.Context;

namespace Project.Persistance.Services.AppServices
{
	public sealed class CompanyService : ICompanyService
	{
		readonly AppDbContext _context;
		readonly IMapper _mapper;

		public CompanyService(AppDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task CreateCompany(CreateCompanyRequest request)
		{
			Company company = _mapper.Map<Company>(request);
			company.Email = "test";
			company.Phone = "test";

			company.TaxDepartment = "ss";
			company.Address = "test";
			company.IdentityNumber = "test";
			company.Id = Guid.NewGuid().ToString();
			await _context.Set<Company>().AddAsync(company);
			await _context.SaveChangesAsync();
		}
	}
}
