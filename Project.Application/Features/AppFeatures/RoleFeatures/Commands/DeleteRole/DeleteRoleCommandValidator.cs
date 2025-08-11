using FluentValidation;

namespace Project.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
	public sealed class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
	{
		public DeleteRoleCommandValidator()
		{
			RuleFor(x=>x.Id).NotEmpty().WithMessage("Id cannot be null!");
			RuleFor(x=>x.Id).NotNull().WithMessage("Id cannot be null!");
		}
	}
}
