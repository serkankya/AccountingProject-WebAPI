using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabases;
using Project.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompanies;
using Project.Presentation.Abstract;

namespace Project.Presentation.Controllers
{
	public class CompaniesController : BaseApiController
	{
		public CompaniesController(IMediator mediator) : base(mediator)
		{
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
		{
			CreateCompanyCommandResponse response = await _mediator.Send(request, cancellationToken);
			return Ok(response);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> MigrateCompanyDatabases()
		{
			MigrateCompanyDatabasesCommand request = new();
			MigrateCompanyDatabasesCommandResponse response = await _mediator.Send(request);

			return Ok(response);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetAllCompanies()
		{
			GetAllCompanyQuery request = new();
			GetAllCompanyQueryResponse response = await _mediator.Send(request);

			return Ok(response);
		}
	}
}
