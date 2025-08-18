using Moq;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;
using Shouldly;

namespace Project.UnitTest.Features.AppFeatures.MainRoleFeatures
{
	public sealed class UpdateMainRoleCommandUnitTest
	{
		readonly Mock<IMainRoleService> _mainRoleService;

		public UpdateMainRoleCommandUnitTest()
		{
			_mainRoleService = new();
		}

		[Fact]
		public async Task MainRoleShouldNotBeNull()
		{
			_mainRoleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new MainRole());
		}

		[Fact]
		public async Task UpdateMainRoleCommandResponseShouldNotBeNull()
		{
			var request = new UpdateMainRoleCommand(
				Id: "1DDB2DEF-7B47-47CD-AB56-E62E86C09DCE",
				Title: "Admin");

			var handler = new UpdateMainRoleCommandHandler(_mainRoleService.Object);

			_mainRoleService.Setup(x => x.GetById(It.IsAny<string>())).ReturnsAsync(new MainRole());

			UpdateMainRoleCommandResponse response = await handler.Handle(request, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
