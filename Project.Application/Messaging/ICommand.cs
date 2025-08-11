using MediatR;

namespace Project.Application.Messaging
{
	public interface ICommand<out TResponse> : IRequest<TResponse>
	{
	}
}
