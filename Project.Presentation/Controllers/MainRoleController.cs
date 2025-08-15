using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRoles;
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

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateStaticMainRole(CancellationToken cancellationToken)
		{
			CreateStaticMainRolesCommand request = new(null);

			CreateStaticMainRolesCommandResponse response = await _mediator.Send(request, cancellationToken);
			return Ok(response);
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> GetAllMainRoles(GetAllMainRolesQuery request)
		{
			GetAllMainRolesQueryResponse response = await _mediator.Send(request, default);
			return Ok(response);
		}
	}
}
