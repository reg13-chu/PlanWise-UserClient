using Microsoft.AspNetCore.Mvc;
using PlanWise_UserClient.Models;
using System;

namespace PlanWise_UserClient.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index(int? year, int? month)
        {
            var currentDate = DateTime.Now;
            int currentYear = year ?? currentDate.Year;
            int currentMonth = month ?? currentDate.Month;

            var bookedDates = new List<DateTime>
            {
                new DateTime(currentYear, currentMonth, 5),
                new DateTime(currentYear, currentMonth, 12),
                new DateTime(currentYear, currentMonth, 18)
            };

            var model = new CalendarViewModel
            {
                Year = currentYear,
                Month = currentMonth,
                BookedDates = bookedDates
            };

            return View(model);
        }
    }
}
