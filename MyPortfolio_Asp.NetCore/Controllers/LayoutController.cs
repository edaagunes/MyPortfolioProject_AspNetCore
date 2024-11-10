using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Asp.NetCore.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
