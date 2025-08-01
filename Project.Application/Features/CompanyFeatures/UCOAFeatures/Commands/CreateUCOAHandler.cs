using MediatR;

namespace Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands
{
	public sealed class CreateUCOAHandler : IRequestHandler<CreateUCOARequest, CreateUCOAResponse>
	{
		public async Task<CreateUCOAResponse> Handle(CreateUCOARequest request, CancellationToken cancellationToken)
		{
			return new();
		}
	}
}
