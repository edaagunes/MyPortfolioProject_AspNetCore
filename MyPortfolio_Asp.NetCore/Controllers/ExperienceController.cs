using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Asp.NetCore.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
