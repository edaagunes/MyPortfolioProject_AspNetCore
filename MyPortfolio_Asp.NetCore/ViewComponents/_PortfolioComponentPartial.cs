using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Asp.NetCore.DAL.Context;

namespace MyPortfolio_Asp.NetCore.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=portfolioContext.Portfolios.ToList();
          
            return View(values);
        }
    }
}
