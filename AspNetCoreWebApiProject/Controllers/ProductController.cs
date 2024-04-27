using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApiProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		public static List<Product> products = new List<Product>()
		{
			new Product(){ProductId = 1, Name = "Product One", Price = 12000},
			new Product(){ProductId = 2, Name = "Product Two", Price = 12000},
			new Product(){ProductId = 3, Name ="Product Three", Price = 12000},
		};
		[HttpGet]
		public List<Product> GetProducts()
		{
			return products; 
		}

		[HttpPost]
		public void  PostProduct()
		{
			products.Add(new Product() { ProductId = 4, Name="product Four",Price=12000 });
		}
	}
}
