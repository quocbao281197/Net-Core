using Microsoft.AspNetCore.Mvc;

namespace Shopping_Cart.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
