using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Asp.NetCore.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
