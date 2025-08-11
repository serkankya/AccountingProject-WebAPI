using FluentValidation;

namespace Project.Application.Features.AppFeatures.AppUserFeatures.LogIn
{
	public class LoginCommandValidator : AbstractValidator<LoginCommand>	
	{
		public LoginCommandValidator()
		{
			RuleFor(p => p.EmailOrUsername).NotNull().WithMessage("You must enter an email or username!");
			RuleFor(p => p.EmailOrUsername).NotEmpty().WithMessage("You must enter an email or username!");
			RuleFor(p => p.Password).NotNull().WithMessage("Password cannot be empty");
			RuleFor(p => p.Password).NotEmpty().WithMessage("Password cannot be empty");
			RuleFor(p => p.Password).MinimumLength(6).WithMessage("Password must be at least 6 characters long");
			RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Your password must contain at least one uppercase letter");
			RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Your password must contain at least one lowercase letter");
			RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Your password must contain at least one number");
			RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Your password must contain at least one special character");

		}
	}
}
