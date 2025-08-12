using Moq;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;
using Shouldly;

namespace Project.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
	public sealed class DeleteRoleCommandUnitTest
	{
		readonly Mock<IRoleService> _roleService;

		public DeleteRoleCommandUnitTest()
		{
			_roleService = new();
		}

		[Fact]
		public async Task RoleShouldNotBeNull()
		{
			_roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
		}

		[Fact]
		public async Task DeleteRoleCommandResponseShouldNotBeNull()
		{
			DeleteRoleCommand request = new(
				Id: "Test Id");

			_roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());

			var handler = new DeleteRoleCommandHandler(_roleService.Object);

			DeleteRoleCommandResponse response = await handler.Handle(request, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
