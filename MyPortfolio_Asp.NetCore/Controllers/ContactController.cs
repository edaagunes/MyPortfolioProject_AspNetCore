using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio_Asp.NetCore.DAL.Context;
using MyPortfolio_Asp.NetCore.DAL.Entities;

namespace MyPortfolio_Asp.NetCore.Controllers
{
	public class ContactController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();

        [HttpGet]
        public IActionResult AddMessage()
        {
            return RedirectToAction("Index", "Default");
        }


        [HttpPost]
		public IActionResult AddMessage(Message message)
		{
                message.SendDate = DateTime.Now;
                message.IsRead = false;

                context.Messages.Add(message);
                context.SaveChanges();

                return RedirectToAction("Index", "Default");  
          
        }
	}
}
