using Microsoft.AspNetCore.Mvc;
using PlanWise_UserClient.Models;

namespace PlanWise_UserClient.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Index(string searchTerm)
        {
            var templates = new List<EventTemplate>
    {
        new EventTemplate { Id = 1, TemplateName = "Wedding", Description = "Elegant and romantic setup", ImagePath = "~/images/wedding.png" },
        new EventTemplate { Id = 2, TemplateName = "Birthday", Description = "Colorful and fun birthday theme", ImagePath = "~/images/birthday.png" },
        new EventTemplate { Id = 3, TemplateName = "Christening", Description = "Professional meeting environment", ImagePath = "~/images/christening.png" },
        new EventTemplate { Id = 4, TemplateName = "Wedding", Description = "Elegant and romantic setup", ImagePath = "~/images/wedding.png" },
        new EventTemplate { Id = 5, TemplateName = "Birthday", Description = "Colorful and fun birthday theme", ImagePath = "~/images/birthday.png" },
        new EventTemplate { Id = 6, TemplateName = "Christening", Description = "Professional meeting environment", ImagePath = "~/images/christening.png" }
    };

            if (!string.IsNullOrEmpty(searchTerm))
            {
                templates = templates
                    .Where(t => t.TemplateName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }


            return View(templates);
        }

    }
}
