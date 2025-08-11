using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

		public async Task<Company?> CheckMigrationIfExists(string name)
		{
			return await _context.Set<Company>().FirstOrDefaultAsync(x=>x.Name == name);	
		}

		public async Task CreateCompany(CreateCompanyCommand request)
		{
			Company company = _mapper.Map<Company>(request);
			company.Id = Guid.NewGuid().ToString();
			await _context.Set<Company>().AddAsync(company);
			await _context.SaveChangesAsync();
		}

		public async Task MigrateCompanyDatabases()
		{
			var companies = await _context.Set<Company>().ToListAsync();

			foreach (var item in companies)
			{
				var database = new CompanyDbContext(item);
				database.Database.Migrate();
			}
		}
	}
}
