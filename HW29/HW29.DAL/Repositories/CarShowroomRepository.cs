using HW29.DAL.Data;
using HW29.DAL.Models;
using HW29.DAL.Repositories.Interfaces;

namespace HW29.DAL.Repositories
{
	public class CarShowroomRepository : Repository<CarShowroom>, ICarShowroomRepository
	{
		private readonly AppDbContext _context;

		public CarShowroomRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}
	}
}
