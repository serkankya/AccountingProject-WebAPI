namespace Project.Domain.Abstract
{
	public abstract class EntityBase
	{
		protected EntityBase()
		{
			
		}

		public EntityBase(string id)
		{
			Id = id;
		}

		public string Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
