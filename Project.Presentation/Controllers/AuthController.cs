using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Features.AppFeatures.AppUserFeatures.LogIn;
using Project.Presentation.Abstract;

namespace Project.Presentation.Controllers
{
	public class AuthController : BaseApiController
	{
		public AuthController(IMediator mediator) : base(mediator)
		{
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> Login(LoginCommand loginRequest)
		{
			LoginResponse response = await _mediator.Send(loginRequest);
			return Ok(response);
		}
	}
}
