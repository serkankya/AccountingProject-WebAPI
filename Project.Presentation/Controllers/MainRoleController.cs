using MediatR;
using Project.Presentation.Abstract;

namespace Project.Presentation.Controllers
{
	public sealed class MainRoleController : BaseApiController
	{
		public MainRoleController(IMediator mediator) : base(mediator)
		{
		}
	}
}
