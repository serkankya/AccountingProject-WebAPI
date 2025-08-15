using Moq;
using Project.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;
using Shouldly;

namespace Project.UnitTest.Features.AppFeatures.MainRoleFeatures
{
	public sealed class CreateMainRoleCommandUnitTest
	{
		readonly Mock<IMainRoleService> _mainRoleService;

		public CreateMainRoleCommandUnitTest()
		{
			_mainRoleService = new();
		}

		[Fact]
		public async Task MainRoleShouldBeNull()
		{
			MainRole mainRole = await _mainRoleService.Object.GetByTitleAndCompanyId(
				title: "Admin",
				companyId: "",
				cancellationToken: default);

			mainRole.ShouldBeNull();
		}

		[Fact] 
		public async Task MainRoleCommandResponseShouldNotBeNull()
		{
			CreateMainRoleCommand request = new(
				Title: "Admin",
				CompanyId: "");

			var handler = new CreateMainRoleCommandHandler(_mainRoleService.Object);

			CreateMainRoleCommandResponse response = await handler.Handle(request, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
