using Microsoft.AspNetCore.Mvc;

namespace Shopping_Cart.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
