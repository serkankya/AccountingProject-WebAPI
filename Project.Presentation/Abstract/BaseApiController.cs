﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Project.Presentation.Abstract
{
	[ApiController]
	[Route("api/[controller]")]
	public class BaseApiController : ControllerBase
	{
		protected readonly IMediator _mediator;

		public BaseApiController(IMediator mediator)
		{
			_mediator = mediator;
		}
	}
}
