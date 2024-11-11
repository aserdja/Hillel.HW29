namespace HW29.DAL.Models
{
	public class Product
	{
		public int Id { get; set; }

		public decimal Price { get; set; }

		public Car Car { get; set; } = null!;
		public int CarId { get; set; }
	}
}
