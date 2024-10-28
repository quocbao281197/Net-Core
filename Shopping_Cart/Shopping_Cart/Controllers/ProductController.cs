using Microsoft.AspNetCore.Mvc;

namespace Shopping_Cart.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Detail()
		{
			return View();
		}
	}
}
