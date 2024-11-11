namespace HW29.DAL.Repositories.Interfaces
{
	public interface IRepository<T>
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
	}
}
