using Microsoft.AspNetCore.Mvc;
using PlanWise_Client.Models;
using PlanWise_UserClient.Models;

namespace PlanWise_UserClient.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            var userEvent = new EventsViewModel
            {
                EventName = "Wedding Planning",
                Step = 1,
                Tasks = new List<TaskItem>
                {
                    new TaskItem { Name = "Venue booked", Status = "In Progress", Notes = "" },
                    new TaskItem { Name = "Catering confirmed", Status = "Done", Notes = "" },
                    new TaskItem { Name = "Photo/video team", Status = "Not Started", Notes = "" },
                    new TaskItem { Name = "Final guest count", Status = "In Progress", Notes = "" },
                    new TaskItem { Name = "Decoration setup", Status = "Not Started", Notes = "" },
                    new TaskItem { Name = "Budget estimate approved", Status = "Done", Notes = "" }
                }
            };

            return View(userEvent);
        }

    }
}