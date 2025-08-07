using MediatR;
using Microsoft.AspNetCore.Mvc;
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

		[HttpPost("[action]")]
		public async Task<IActionResult> UpdateRole(UpdateRoleRequest request)
		{
			UpdateRoleResponse response = await _mediator.Send(request);
			return Ok(response);
		}

		[HttpGet("[action]/{id}")]
		public async Task<IActionResult> DeleteRole(string id)
		{
			DeleteRoleRequest request = new DeleteRoleRequest
			{
				Id = id
			};

			DeleteRoleResponse response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
