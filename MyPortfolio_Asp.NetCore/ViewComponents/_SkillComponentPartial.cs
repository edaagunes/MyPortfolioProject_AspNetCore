using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Asp.NetCore.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
