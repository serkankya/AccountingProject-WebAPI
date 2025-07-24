using Project.Domain.Abstract;
using Project.Domain.MainEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.MainEntities
{
	public class UserCompany : EntityBase
	{
		public string AppUserId { get; set; }
		[ForeignKey("AppUserId")]
		public AppUser AppUser { get; set; }

		public string CompanyId { get; set; }
		[ForeignKey("CompanyId")]
		public Company Company { get; set; }
	}
}
