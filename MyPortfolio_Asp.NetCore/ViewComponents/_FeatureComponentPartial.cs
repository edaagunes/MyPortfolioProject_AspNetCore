using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Asp.NetCore.DAL.Context;

namespace MyPortfolio_Asp.NetCore.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
