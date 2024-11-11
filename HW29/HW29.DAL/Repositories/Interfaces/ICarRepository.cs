using HW29.DAL.Models;

namespace HW29.DAL.Repositories.Interfaces
{
	public interface ICarRepository : IRepository<Car>
	{
		Task<Car?> GetByIdAsync(int carId);
	}
}
