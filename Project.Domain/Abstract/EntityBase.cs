namespace Project.Domain.Abstract
{
	public class EntityBase
	{
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
