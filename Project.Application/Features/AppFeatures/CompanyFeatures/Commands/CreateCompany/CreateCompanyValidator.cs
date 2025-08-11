using FluentValidation;

namespace Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
	public sealed class CreateCompanyValidator : AbstractValidator<CreateCompanyCommand>
	{
		public CreateCompanyValidator()
		{
			RuleFor(x => x.DatabaseName).NotEmpty().WithMessage("Database information is required!");
			RuleFor(x => x.DatabaseName).NotNull().WithMessage("Database information is required!");
			RuleFor(x => x.ServerName).NotEmpty().WithMessage("Server information is required!");
			RuleFor(x => x.ServerName).NotNull().WithMessage("Server information is required!");
			RuleFor(x => x.Name).NotEmpty().WithMessage("Company name is required!");
			RuleFor(x => x.Name).NotNull().WithMessage("Company name is required!");
		}
	}
}
