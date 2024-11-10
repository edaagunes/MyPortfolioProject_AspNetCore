﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Asp.NetCore.DAL.Context;
using MyPortfolio_Asp.NetCore.DAL.Entities;

namespace MyPortfolio_Asp.NetCore.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult ExperienceList()
		{
			var values = context.Experiences.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiences.Add(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

		public IActionResult DeleteExperience(int id)
		{
			var value = context.Experiences.Find(id);
			context.Experiences.Remove(value);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var values = context.Experiences.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			context.Experiences.Update(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
