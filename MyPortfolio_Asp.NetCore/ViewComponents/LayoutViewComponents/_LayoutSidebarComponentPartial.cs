using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio_Asp.NetCore.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
