using Project.Domain.Abstract;
using Project.Domain.MainEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.MainEntities
{
	public sealed class MainRoleAndUser : EntityBase
	{
		[ForeignKey("AppUser")]
		public string UserId { get; set; }
		public AppUser AppUser { get; set; }

		[ForeignKey("MainRole")]
		public string MainRoleId { get; set; }
		public MainRole MainRole { get; set; }

		[ForeignKey("Company")]
		public string CompanyId { get; set; }
		public Company Company { get; set; }
	}
}
