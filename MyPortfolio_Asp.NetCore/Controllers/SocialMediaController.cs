using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Asp.NetCore.DAL.Context;
using MyPortfolio_Asp.NetCore.DAL.Entities;

namespace MyPortfolio_Asp.NetCore.Controllers
{
	public class SocialMediaController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = context.SocialMedias.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteSocialMedia(int id)
		{
			var value = context.SocialMedias.Find(id);
			context.SocialMedias.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var values = context.SocialMedias.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Update(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
