using FluentValidation;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
	public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
	{
		public CreateRoleCommandValidator()
		{
			RuleFor(x => x.Code).NotEmpty().WithMessage("Role code cannot be empty!");
			RuleFor(x => x.Code).NotNull().WithMessage("Role code cannot be empty!");
			RuleFor(x => x.Name).NotEmpty().WithMessage("Role name cannot be empty!");
			RuleFor(x => x.Name).NotNull().WithMessage("Role name cannot be empty!");
		}
	}
}
