using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Asp.NetCore.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
