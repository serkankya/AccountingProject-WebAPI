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
		public async Task<IActionResult> CreateUCOA(CreateUCOACommand request, CancellationToken cancellationToken)
		{
			CreateUCOACommandResponse response = await _mediator.Send(request, cancellationToken);
			return Ok(response);
		}
	}
}
