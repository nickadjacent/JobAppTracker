using JobAppTracker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobAppTracker.Controllers
{
    public class JobAppTrackerController : Controller
    {
        private JobAppTrackerContext db;
        public JobAppTrackerController(JobAppTrackerContext context)
        {
            db = context;
        }
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            if (uid == null)
            {
                return RedirectToAction("Index", "Home");
            }

            // List<FoodTruck> allTrucks = db.FoodTrucks
            //     .Include(truck => truck.Reviews)
            //     .ToList();

            return View("Dashboard");
        }
    }
}