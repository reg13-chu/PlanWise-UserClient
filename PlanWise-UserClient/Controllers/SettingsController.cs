using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PlanWise_UserClient.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PlanWise_UserClient.Controllers
{
    public class SettingsController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Settings
        public IActionResult Index()
        {
            var model = new SettingsViewModel
            {
                ProfileImagePath = "default-profile.png" // set default image
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(SettingsViewModel model)
        {
            if (model.ProfileImage != null && model.ProfileImage.Length > 0)
            {
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                Directory.CreateDirectory(uploadsFolder); // make sure the folder exists

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.ProfileImage.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.ProfileImage.CopyToAsync(stream);
                }

                model.ProfileImagePath = fileName;
            }
            else
            {
                // If no file uploaded, keep using existing or default image
                model.ProfileImagePath = model.ProfileImagePath ?? "default-profile.png";
            }

            return View("Index", model); // return back to same view
        }
    }
}
