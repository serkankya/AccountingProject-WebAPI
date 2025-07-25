namespace Project.Domain.Abstract
{
	public abstract class EntityBase
	{
		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
