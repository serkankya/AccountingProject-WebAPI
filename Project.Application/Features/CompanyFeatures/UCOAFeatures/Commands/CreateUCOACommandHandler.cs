using MediatR;
using Project.Application.Messaging;
using Project.Application.Services.CompanyServices;

namespace Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands
{
	public sealed class CreateUCOACommandHandler : ICommandHandler<CreateUCOACommand, CreateUCOACommandResponse>
	{
		readonly IUCOAService _ucoaService;

		public CreateUCOACommandHandler(IUCOAService ucoaService)
		{
			_ucoaService = ucoaService;
		}

		public async Task<CreateUCOACommandResponse> Handle(CreateUCOACommand request, CancellationToken cancellationToken)
		{
			await _ucoaService.CreateUCOAAsync(request,cancellationToken);
			return new();
		}
	}
}
