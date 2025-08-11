using MediatR;

namespace Project.Application.Messaging
{
	public interface IQuery<out TResponse> : IRequest<TResponse>
	{
	}
}
