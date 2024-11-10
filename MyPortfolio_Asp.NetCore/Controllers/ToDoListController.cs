using Microsoft.AspNetCore.Mvc;
using MyPortfolio_Asp.NetCore.DAL.Context;
using MyPortfolio_Asp.NetCore.DAL.Entities;

namespace MyPortfolio_Asp.NetCore.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = context.ToDoLists.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDo)
		{
			context.ToDoLists.Add(toDo);
			context.SaveChanges();	
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{
			var value=context.ToDoLists.Find(id);
			context.ToDoLists.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var values=context.ToDoLists.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDo)
		{
			context.ToDoLists.Update(toDo);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
