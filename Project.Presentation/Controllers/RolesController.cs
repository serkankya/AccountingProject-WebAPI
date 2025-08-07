using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Project.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
using Project.Presentation.Abstract;

namespace Project.Presentation.Controllers
{
	public class RolesController : BaseApiController
	{
		public RolesController(IMediator mediator) : base(mediator)
		{
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetAllRoles()
		{
			GetAllRolesRequest request = new();

			GetAllRolesResponse response = await _mediator.Send(request);
			return Ok(response);
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateRole(CreateRoleRequest request)
		{
			CreateRoleResponse response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
