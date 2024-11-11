using HW29.DAL.Data;
using HW29.DAL.Models;
using HW29.DAL.Repositories.Interfaces;

namespace HW29.DAL.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		private readonly AppDbContext _context;

		public ProductRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}
	}
}
