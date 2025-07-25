using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabases;
using Project.Presentation.Abstract;

namespace Project.Presentation.Controllers
{
	public class CompaniesController : BaseApiController
	{
		public CompaniesController(IMediator mediator) : base(mediator)
		{
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateCompany(CreateCompanyRequest request)
		{
			CreateCompanyResponse response = await _mediator.Send(request);
			return Ok(response);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> MigrateCompanyDatabases()
		{
			MigrateCompanyDatabasesRequest request = new();
			MigrateCompanyDatabasesResponse response = await _mediator.Send(request);

			return Ok(response);
		}
	}
}
