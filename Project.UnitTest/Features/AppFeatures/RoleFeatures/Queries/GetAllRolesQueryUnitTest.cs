using Moq;
using Project.Application.Services.AppServices;
using Project.Domain.MainEntities.Identity;

namespace Project.UnitTest.Features.AppFeatures.RoleFeatures.Queries
{
	public sealed class GetAllRolesQueryUnitTest 
	{
		readonly Mock<IRoleService> _roleService;

		public GetAllRolesQueryUnitTest()
		{
			_roleService = new();
		}

		[Fact]
		public async Task GetAllRolesQueryResponseShouldNotBeNull()
		{
			_roleService.Setup(x => x.GetAllRolesAsync()).ReturnsAsync(new List<AppRole>());
		}
	}
}
