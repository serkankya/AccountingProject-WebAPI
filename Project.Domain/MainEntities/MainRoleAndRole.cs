using Project.Domain.Abstract;
using Project.Domain.MainEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.MainEntities
{
	public sealed class MainRoleAndRole : EntityBase
	{
		[ForeignKey("AppRole")]
		public string RoleId { get; set; }
		public AppRole AppRole { get; set; }

		[ForeignKey("MainRole")]
		public string MainRoleId { get; set; }
		public MainRole MainRole { get; set; }
	}
}
