using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Asp.NetCore.DAL.Context;
using MyPortfolio_Asp.NetCore.DAL.Entities;

namespace MyPortfolio_Asp.NetCore.Controllers
{
	public class PhoneController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult Index()
		{
			var values=context.Contacts.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult UpdatePhone(int id)
		{
			var values = context.Contacts.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdatePhone(Contact contact)
		{
			context.Contacts.Update(contact);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
