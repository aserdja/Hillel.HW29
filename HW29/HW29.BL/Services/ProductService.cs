using HW29.BL.Services.Interfaces;
using HW29.DAL.Repositories.Interfaces;

namespace HW29.BL.Services
{
	public class ProductService(IProductRepository productRepository, ICarRepository carRepository) : IProductService
	{
		private readonly IProductRepository _productRepository = productRepository;
		private readonly ICarRepository _carRepository = carRepository;

		public async Task SellCarAsync(int productId)
		{
			var product = await _productRepository.GetByIdAsync(productId);
			var car = await _carRepository.GetByIdAsync(productId);
			
			if (product == null | car == null)
			{
				throw new Exception("Product or car not found");
			}

			await _productRepository.DeleteAsync(product);
			await _carRepository.DeleteAsync(car);
		}
	}
}
