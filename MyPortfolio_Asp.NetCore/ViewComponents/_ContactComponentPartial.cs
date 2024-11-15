﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Asp.NetCore.DAL.Context;
using MyPortfolio_Asp.NetCore.DAL.Entities;

namespace MyPortfolio_Asp.NetCore.ViewComponents
{
	public class _ContactComponentPartial : ViewComponent
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = portfolioContext.Contacts.ToList();
			return View(values);
		}

	}
}
