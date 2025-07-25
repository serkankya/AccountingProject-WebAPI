using Project.Domain.Abstract;

namespace Project.Domain.CompanyEntities
{
	public class UCOA : EntityBase
	{
		public string CompanyId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public char Type { get; set; }
	}
}
