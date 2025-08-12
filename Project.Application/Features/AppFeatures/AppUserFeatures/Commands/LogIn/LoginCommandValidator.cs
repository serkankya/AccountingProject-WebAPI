using FluentValidation;

namespace Project.Application.Features.AppFeatures.AppUserFeatures.Commands.LogIn
{
	public class LoginCommandValidator : AbstractValidator<LoginCommand>	
	{
		public LoginCommandValidator()
		{
			RuleFor(x => x.EmailOrUsername).NotNull().WithMessage("You must enter an email or username!");
			RuleFor(x => x.EmailOrUsername).NotEmpty().WithMessage("You must enter an email or username!");
			RuleFor(x => x.Password).NotNull().WithMessage("Password cannot be empty");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty");
			RuleFor(x => x.Password).MinimumLength(6).WithMessage("Password must be at least 6 characters long");
			RuleFor(x => x.Password).Matches("[A-Z]").WithMessage("Your password must contain at least one uppercase letter");
			RuleFor(x => x.Password).Matches("[a-z]").WithMessage("Your password must contain at least one lowercase letter");
			RuleFor(x => x.Password).Matches("[0-9]").WithMessage("Your password must contain at least one number");
			RuleFor(x => x.Password).Matches("[^a-zA-Z0-9]").WithMessage("Your password must contain at least one special character");
		}
	}
}
