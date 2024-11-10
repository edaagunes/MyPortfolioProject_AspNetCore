using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Asp.NetCore.DAL.Context;

namespace MyPortfolio_Asp.NetCore.Controllers
{
	public class DefaultController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult Index()
		{			
			return View();
		}
	}
}
