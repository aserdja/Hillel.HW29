namespace HW29.DAL.Models
{
	public class CarShowroom
	{
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public string Address { get; set; } = string.Empty;

		public ICollection<Product>? Products { get; set; }
	}
}
