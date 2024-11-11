using HW29.BL.Services.Interfaces;
using HW29.DAL.Repositories.Interfaces;

namespace HW29.BL.Services
{
	public class ProductService(IProductRepository repository) : IProductService
	{
		private readonly IProductRepository _repository = repository;

		public async Task SellCar(int productId)
		{
			var product = await _repository.GetByIdAsync(productId);		
			
			if (product == null)
			{
				throw new Exception("Product not found");
			}

			await _repository.DeleteAsync(product);
		}
	}
}
