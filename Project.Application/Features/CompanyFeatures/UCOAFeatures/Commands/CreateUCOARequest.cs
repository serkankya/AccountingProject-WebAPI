using MediatR;

namespace Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands
{
	public sealed class CreateUCOARequest : IRequest<CreateUCOAResponse>
	{
		public string CompanyId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public char Type { get; set; }
	}
}
