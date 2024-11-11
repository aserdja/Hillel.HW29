using HW29.DAL.Data;
using HW29.DAL.Models;
using HW29.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HW29.DAL.Repositories
{
	public class CarRepository : Repository<Car>, ICarRepository
	{
		private readonly AppDbContext _context;

		public CarRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<Car?> GetByIdAsync(int carId)
		{
			return await _context.Cars.FirstOrDefaultAsync(c => c.Id.Equals(carId));
		}
	}
}
