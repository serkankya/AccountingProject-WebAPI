using Microsoft.EntityFrameworkCore;

namespace Project.Domain
{
	public interface IContextService
	{
		DbContext CreateDbContextInstance(string companyId);
	}
}
