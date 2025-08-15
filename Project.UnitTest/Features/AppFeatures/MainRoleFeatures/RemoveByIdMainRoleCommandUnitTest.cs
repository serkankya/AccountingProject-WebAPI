using Moq;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using Project.Application.Services.AppServices;
using Shouldly;

namespace Project.UnitTest.Features.AppFeatures.MainRoleFeatures
{
	public sealed class RemoveByIdMainRoleCommandUnitTest
	{
		readonly Mock<IMainRoleService > _mainRoleService;

		public RemoveByIdMainRoleCommandUnitTest()
		{
			_mainRoleService = new();
		}

		[Fact]
		public async Task RemoveByIdMainRoleCommandResponseShouldNotBeNull()
		{
			var request = new RemoveByIdMainRoleCommand(
				Id: "7e98714f-0ceb-4ff1-bb4a-37fe4935f38f");

			var handler = new RemoveByIdMainRoleCommandHandler(_mainRoleService.Object);

			RemoveByIdMainRoleCommandResponse response = await handler.Handle(request, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
