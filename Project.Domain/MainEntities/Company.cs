using Project.Domain.Abstract;

namespace Project.Domain.MainEntities
{
	public class Company : EntityBase
	{
		public string? Name { get; set; }
		public string? Address { get; set; }
		public string? IdentityNumber { get; set; }
		public string? TaxDepartment { get; set; }
		public string? Phone { get; set; }
		public string? Email { get; set; }
		public string? ServerName { get; set; }
		public string? DatabaseName { get; set; }
		public string? UserId { get; set; }
		public string? Password { get; set; }
	}
}
