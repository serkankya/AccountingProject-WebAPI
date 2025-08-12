using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
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
			GetAllRolesQuery request = new();

			GetAllRolesQueryResponse response = await _mediator.Send(request);
			return Ok(response);
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateRole(CreateRoleCommand request)
		{
			CreateRoleCommandResponse response = await _mediator.Send(request);
			return Ok(response);
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> UpdateRole(UpdateRoleCommand request)
		{
			UpdateRoleCommandResponse response = await _mediator.Send(request);
			return Ok(response);
		}

		[HttpGet("[action]/{id}")]
		public async Task<IActionResult> DeleteRole(string id)
		{
			DeleteRoleCommand request = new DeleteRoleCommand(id);

			DeleteRoleCommandResponse response = await _mediator.Send(request);
			return Ok(response);
		}

		[HttpGet("[action]")]
		public async Task<IActionResult> CreateAllRoles()
		{
			CreateAllRolesCommand request = new();
			CreateAllRolesCommandResponse response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
