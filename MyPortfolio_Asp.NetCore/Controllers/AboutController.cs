using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio_Asp.NetCore.DAL.Context;
using MyPortfolio_Asp.NetCore.DAL.Entities;

namespace MyPortfolio_Asp.NetCore.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();

		[HttpGet]
		public IActionResult Index()
		{
			var values=context.Abouts.ToList();
			return View(values);
		}

		[HttpPost]
		public IActionResult Index(int id)
		{
			var values = context.Abouts.ToList();
			foreach (var about in values)
			{
				about.Status = false;
			}

			// Seçilen kayıtı aktif yap
			var selectedAbout = context.Abouts.Find(id);
			if (selectedAbout != null)
			{
				selectedAbout.Status = true;
			}

			context.SaveChanges();

			return RedirectToAction("Index");

		}

		[HttpGet]
		public IActionResult CreateAbout()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateAbout(About about)
		{
			context.Abouts.Add(about);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var values = context.Abouts.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateAbout(About about)
		{
			context.Abouts.Update(about);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
