using HW29.DAL.Models;

namespace HW29.DAL.Repositories.Interfaces
{
	public interface IProductRepository : IRepository<Product>
	{
		Task<Product?> GetByIdAsync(int id);
	}
}
