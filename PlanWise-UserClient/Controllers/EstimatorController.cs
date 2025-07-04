using Microsoft.AspNetCore.Mvc;
using PlanWise_UserClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanWise_UserClient.Controllers
{
    public class EstimatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Return empty model when first loading the page
            return View(new EstimatorViewModel());
        }

        [HttpPost]
        public IActionResult Index(EstimatorViewModel model)
        {
            var breakdown = new Dictionary<string, decimal>();
            decimal perHeadCateringCost = 0;

            switch (model.EventType)
            {
                case "Wedding":
                    breakdown = new()
            {
                { "Venue", 0.25m },
                { "Photo/Video", 0.15m },
                { "Decorations", 0.10m },
                { "Entertainment/Host", 0.10m },
                { "Miscellaneous", 0.10m }
            };
                    perHeadCateringCost = 600;
                    break;

                case "Birthday":
                    breakdown = new()
            {
                { "Venue", 0.20m },
                { "Decorations", 0.15m },
                { "Entertainment", 0.15m },
                { "Miscellaneous", 0.10m }
            };
                    perHeadCateringCost = 400;
                    break;

                case "Christening":
                    breakdown = new()
            {
                { "Venue", 0.20m },
                { "Decorations", 0.20m },
                { "Souvenirs", 0.15m },
                { "Miscellaneous", 0.10m }
            };
                    perHeadCateringCost = 350;
                    break;
            }

            // Calculate catering
            var cateringTotal = model.NumberOfGuests * perHeadCateringCost;

            // Compute other category costs
            var otherCategoryCosts = breakdown.Sum(x => model.TotalBudget * x.Value);

            // Total cost needed
            var totalNeeded = cateringTotal + otherCategoryCosts;

            if (totalNeeded > model.TotalBudget)
            {
                ModelState.AddModelError("", $"Your budget is not enough to accommodate {model.NumberOfGuests} guests for a {model.EventType.ToLower()}.");
                return View(model);
            }

            // Proceed to breakdown
            model.CategoryBreakdown = breakdown.ToDictionary(
                x => x.Key,
                x => Math.Round(model.TotalBudget * x.Value, 2)
            );

            model.CategoryBreakdown.Add("Catering", Math.Round(cateringTotal, 2));

            return View(model);
        }


    }
}
