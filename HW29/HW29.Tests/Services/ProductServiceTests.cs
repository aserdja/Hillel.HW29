using HW29.BL.Services;
using HW29.BL.Services.Interfaces;
using HW29.DAL.Data;
using HW29.DAL.Models;
using HW29.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HW29.Tests.Services
{
	public class ProductServiceTests
	{
		[Fact]
		public async Task SellCarAsync_expects_remove_product_and_car_from_db()
		{
			var context = new AppDbContext();
			var car = new Car { Brand = "TestCarBrand", Model = "TestCarModel" };
			var product = new Product { Price = 50000, Car = car};
			var carRepo = new CarRepository(context);
			var productRepo = new ProductRepository(context);
			IProductService productService = new ProductService(productRepo, carRepo);

			await carRepo.AddAsync(car);
			await productRepo.AddAsync(product);
			var carToSell = await context.Cars.FirstOrDefaultAsync(c => c.Brand.Equals(car.Brand) && c.Model.Equals(car.Model));
			var productToSell = await context.Products.FirstOrDefaultAsync(p => p.Price.Equals(product.Price) && p.Car.Id.Equals(carToSell.Id));


			await productService.SellCarAsync(productToSell.Id);


			var deletedProduct = await context.Products.FirstOrDefaultAsync(p => p.Id.Equals(productToSell.Id));
			Assert.Null(deletedProduct);
		}
	}
}
