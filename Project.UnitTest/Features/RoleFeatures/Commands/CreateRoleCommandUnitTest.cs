using Moq;
using Project.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;
using Shouldly;

namespace Project.UnitTest.Features.RoleFeatures.Commands
{
	public sealed class CreateRoleCommandUnitTest
	{
		readonly Mock<IRoleService> _roleService;

		public CreateRoleCommandUnitTest()
		{
			_roleService = new();
		}

		[Fact]
		public async Task RoleCodeShouldBeNull()
		{
			AppRole role = (await _roleService.Object.GetByCode("ABC"))!;
			role.ShouldBeNull();
		}

		[Fact]
		public async Task CreateRoleCommandResponseShouldNotBeNull()
		{
			CreateRoleCommand request = new(
				Code: "ABC",
				Name: "Test Name");

			var handler = new CreateRoleCommandHandler(_roleService.Object);
			CreateRoleCommandResponse response = await handler.Handle(request, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
