using Microsoft.AspNetCore.Mvc;
using PlanWise_UserClient.Models;

namespace PlanWise_UserClient.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index(string eventType, decimal budget, int numberOfGuests)
        {
            var model = new BookingViewModel
            {
                EventType = eventType,
                EstimatedBudget = budget,
                NumberOfGuests = numberOfGuests
                
            };
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(BookingViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulate saving (can be to DB or session or file, depende sa setup)
                // Example:
                // _context.Bookings.Add(model);
                // _context.SaveChanges();

                return RedirectToAction("Confirmation");
            }

            return View(model); // if may validation errors, balik sa form
        }

        public IActionResult Confirmation()
        {
            return View();
        }

    }

}
