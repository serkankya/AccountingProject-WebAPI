using Project.Application.Messaging;
using Project.Application.Services.CompanyServices;
using Project.Domain.CompanyEntities;

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
			UCOA ucoa = await _ucoaService.GetByCode(request.Code, cancellationToken);

			if (ucoa != null)
				throw new Exception("This code already exists!");

			await _ucoaService.CreateUCOAAsync(request, cancellationToken);
			return new();
		}
	}
}
