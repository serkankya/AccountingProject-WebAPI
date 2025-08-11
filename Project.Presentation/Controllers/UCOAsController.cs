using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands;
using Project.Presentation.Abstract;
using System.Threading.Tasks;

namespace Project.Presentation.Controllers
{
	public class UCOAsController : BaseApiController
	{
		public UCOAsController(IMediator mediator) : base(mediator)
		{
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateUCOA(CreateUCOACommand request)
		{
			CreateUCOACommandResponse response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
