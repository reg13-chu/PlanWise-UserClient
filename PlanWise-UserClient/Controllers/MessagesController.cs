using Microsoft.AspNetCore.Mvc;
using PlanWise_UserClient.Models;

namespace PlanWise_UserClient.Controllers
{
    public class MessagesController : Controller
    {
        public IActionResult Index()
        {
            var messages = new List<Messages>
    {
            new Messages { Content = "Hi! Kumusta?", IsSender = false },
            new Messages { Content = "Okay lang! Ikaw?", IsSender = true },
            new Messages { Content = "All good. May tanong ako.", IsSender = false },
            new Messages { Content = "Sure, ano 'yon?", IsSender = true }
    };

            return View(messages);
        }
    }
}
