﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Asp.NetCore.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
