using FluentValidation;

namespace Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands
{
	public sealed class CreateUCOACommandValidator : AbstractValidator<CreateUCOACommand>
	{
		public CreateUCOACommandValidator()
		{
			RuleFor(p => p.Code).NotEmpty().WithMessage("Account plan code cannot be empty!");
			RuleFor(p => p.Code).NotNull().WithMessage("Account plan code cannot be null!");
			//RuleFor(p => p.Code).MinimumLength(5).WithMessage("Account plan code must be at least 5 characters long!");

			RuleFor(p => p.Name).NotEmpty().WithMessage("Account plan name cannot be empty!");
			RuleFor(p => p.Name).NotNull().WithMessage("Account plan name cannot be null!");

			RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Company information cannot be empty!");
			RuleFor(p => p.CompanyId).NotNull().WithMessage("Company information cannot be null!");

			RuleFor(p => p.Type).NotNull().WithMessage("Account plan type cannot be null!");
			RuleFor(p => p.Type).NotEmpty().WithMessage("Account plan type cannot be empty!");
			//RuleFor(p => p.Type).MaximumLength(1).WithMessage("Account plan type must be 1 character long!");
		}
	}
}
