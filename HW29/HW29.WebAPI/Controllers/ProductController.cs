using HW29.BL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HW29.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController(IProductService productService) : Controller
	{
		private readonly IProductService _productService = productService;

		[HttpDelete]
		public async Task<IActionResult> SellCar(int productId)
		{
			try
			{
				await _productService.SellCarAsync(productId);

				return Ok();
			}
			catch (Exception)
			{
				return NotFound();
			}
		}
	}
}
