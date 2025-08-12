using Moq;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;
using Shouldly;

namespace Project.UnitTest.Features.RoleFeatures.Commands
{
	public sealed class UpdateRoleCommandUnitTest
	{
		readonly Mock<IRoleService> _roleService;

		public UpdateRoleCommandUnitTest()
		{
			_roleService = new();
		}

		[Fact]
		public async Task RoleShouldNotBeNull()
		{
			_roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
		}

		[Fact]
		public async Task RoleCodeShouldBeNull()
		{
			AppRole role = (await _roleService.Object.GetByCode("Test Code")!);
			role.ShouldBeNull();
		}

		[Fact]
		public async Task UpdateRoleCommandResponseShouldNotBeNull()
		{
			UpdateRoleCommand request = new(
				Id: "Test Id",
				Code: "Test Code",
				Name: "Test Name");

			_roleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());

			var handler = new UpdateRoleCommandHandler(_roleService.Object);

			UpdateRoleCommandResponse response = await handler.Handle(request, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
