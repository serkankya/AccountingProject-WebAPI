using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Project.Presentation.Abstract;

namespace Project.Presentation.Controllers
{
	public sealed class MainRoleController : BaseApiController
	{
		public MainRoleController(IMediator mediator) : base(mediator)
		{
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateMainRole(CreateMainRoleCommand request)
		{
			CreateMainRoleCommandResponse response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
