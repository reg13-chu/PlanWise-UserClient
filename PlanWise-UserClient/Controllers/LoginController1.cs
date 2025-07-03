using Microsoft.AspNetCore.Mvc;
using PlanWise_UserClient.Models; 

namespace PlanWise_UserClient.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Index", model);

            // Sample login logic
            if (model.Username == "admin" && model.Password == "1234")
            {
                // TODO: Save session/auth logic here
                return RedirectToAction("Index", "Dashboard"); 
            }

            ModelState.AddModelError("", "Invalid credentials");
            return View("Index", model);
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
