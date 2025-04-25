using System.Diagnostics;
using Lecture57.Models;
using Lecture57.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lecture57.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string data = String.Empty;

            if (HttpContext.Session.Keys.Contains("first_request"))
            {
                string firstVisitedDateTime = HttpContext.Session.GetString("first_request");
                // Cookie exists
                data = "Welcome back " + firstVisitedDateTime;
            }
            else
            {
                
                // Cookie does not exist
                data = "You visited First time";
                HttpContext.Session.SetString("first_request", System.DateTime.Now.ToString());
            }

            // Check if the cookie exists
            return View("index", data);
        }

        public IActionResult Remove()    // add /home/remove to remove the cookie from the website
        {
            string confirmationMsg = "The SESSION is removed ...";

            HttpContext.Session.Remove("first_request");
            return View("Index", confirmationMsg);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}