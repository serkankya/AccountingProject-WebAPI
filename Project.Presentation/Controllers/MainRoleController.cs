using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
using Project.Presentation.Abstract;

namespace Project.Presentation.Controllers
{
	public sealed class MainRoleController : BaseApiController
	{
		public MainRoleController(IMediator mediator) : base(mediator)
		{
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateMainRole(CreateMainRoleCommand request, CancellationToken cancellationToken)
		{
			CreateMainRoleCommandResponse response = await _mediator.Send(request, cancellationToken);
			return Ok(response);
		}

		[HttpPost]
		public async Task<IActionResult> CreateStaticMainRole(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
		{
			CreateStaticMainRolesCommandResponse response = await _mediator.Send(request, cancellationToken);
			return Ok(response);
		}
	}
}
