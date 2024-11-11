using HW29.DAL.Data;
using HW29.DAL.Models;
using HW29.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HW29.DAL.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		private readonly AppDbContext _context;

		public ProductRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<Product?> GetByIdAsync(int id)
		{
			return await _context.Products.FirstOrDefaultAsync(p => p.Id.Equals(id));
		}
	}
}
