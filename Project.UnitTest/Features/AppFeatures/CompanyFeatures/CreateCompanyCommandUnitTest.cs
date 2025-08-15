using Moq;
using Project.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities;
using Shouldly;

namespace Project.UnitTest.Features.AppFeatures.CompanyFeatures
{

	public sealed class CreateCompanyCommandUnitTest
	{
		readonly Mock<ICompanyService> _companyService;

		public CreateCompanyCommandUnitTest()
		{
			_companyService = new();
		}

		[Fact]
		public async Task CompanyShouldBeNull()
		{
			Company company = (await _companyService.Object.CheckMigrationIfExists("Test Company Ltd", default))!;
			company.ShouldBeNull();
		}

		[Fact]
		public async Task CreateCompanyCommandResponseShouldNotBeNull()
		{
			CreateCompanyCommand request = new(
				Name: "Test",
				ServerName: "ServerTest",
				DatabaseName: "DatabaseTest",
				UserId: "",
				Password: "");

			var handler = new CreateCompanyCommandHandler(_companyService.Object);

			CreateCompanyCommandResponse response = await handler.Handle(request, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
