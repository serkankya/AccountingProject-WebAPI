using Project.Domain.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.MainEntities
{
	public sealed class MainRole : EntityBase
	{
		public string Title { get; set; }
		public bool IsRoleCreatedByAdmin { get; set; }

		[ForeignKey("Company")]
		public string CompanyId { get; set; }
		public Company? Company { get; set; }
	}
}
