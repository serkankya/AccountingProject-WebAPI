using MediatR;
using Project.Application.Services.CompanyServices;

namespace Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands
{
	public sealed class CreateUCOAHandler : IRequestHandler<CreateUCOARequest, CreateUCOAResponse>
	{
		readonly IUCOAService _ucoaService;

		public CreateUCOAHandler(IUCOAService ucoaService)
		{
			_ucoaService = ucoaService;
		}

		public async Task<CreateUCOAResponse> Handle(CreateUCOARequest request, CancellationToken cancellationToken)
		{
			await _ucoaService.CreateUCOAAsync(request);
			return new();
		}
	}
}
