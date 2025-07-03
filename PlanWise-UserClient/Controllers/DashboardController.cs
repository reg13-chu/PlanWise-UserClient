using Microsoft.AspNetCore.Mvc;
using PlanWise_UserClient.Models;

namespace PlanWise_UserClient.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var tasks = new List<ChecklistItem>
            {
                new ChecklistItem { TaskName = "Buy supplies", IsCompleted = true },
                new ChecklistItem { TaskName = "Prepare report", IsCompleted = false },
                new ChecklistItem { TaskName = "Send emails", IsCompleted = true }
            };

            var requirement = new List<ChecklistItem>
            {
                new ChecklistItem { TaskName = "[Requirment 1]", IsCompleted = true },
                new ChecklistItem { TaskName = "[Requirment 2]", IsCompleted = false },
                new ChecklistItem { TaskName = "[Requirment 3]", IsCompleted = true }
            };

            var combined = Tuple.Create(tasks, requirement);
            return View(combined);
        }
    }
}
