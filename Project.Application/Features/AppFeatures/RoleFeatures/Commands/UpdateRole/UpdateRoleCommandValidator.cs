using FluentValidation;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
	public sealed class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
	{
		public UpdateRoleCommandValidator()
		{
			RuleFor(x => x.Id).NotEmpty().WithMessage("Id cannot be empty!");
			RuleFor(x => x.Id).NotNull().WithMessage("Id cannot be empty!");
			RuleFor(x => x.Code).NotEmpty().WithMessage("Role code cannot be empty!");
			RuleFor(x => x.Code).NotNull().WithMessage("Role code cannot be empty!");
			RuleFor(x => x.Name).NotEmpty().WithMessage("Role name cannot be empty!");
			RuleFor(x => x.Name).NotNull().WithMessage("Role name cannot be empty!");
		}
	}
}
