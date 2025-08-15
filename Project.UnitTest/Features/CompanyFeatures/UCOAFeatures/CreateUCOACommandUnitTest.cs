using Moq;
using Project.Application.Features.CompanyFeatures.UCOAFeatures.Commands;
using Project.Application.Services.CompanyServices;
using Project.Domain.CompanyEntities;
using Shouldly;

namespace Project.UnitTest.Features.CompanyFeatures.UCOAFeatures
{
	public sealed class CreateUCOACommandUnitTest
	{
		readonly Mock<IUCOAService> _ucoaService;

		public CreateUCOACommandUnitTest()
		{
			_ucoaService = new();
		}

		[Fact]	
		public async Task UCOACodeShouldBeNull()
		{
			UCOA ucoa = await _ucoaService.Object.GetByCode("Test Code",default);
			ucoa.ShouldBeNull();
		}

		[Fact]
		public async Task CreateUCOACommandResponseShouldNotBeNull()
		{
			CreateUCOACommand request = new(
				CompanyId: "Test Id",
				Code: "Test Code",
				Name: "Test Name",
				Type: 'C');

			var handler = new CreateUCOACommandHandler(_ucoaService.Object);

			CreateUCOACommandResponse response = await handler.Handle(request, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
