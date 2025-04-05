using System.Diagnostics;
using Lecture56.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lecture56.Controllers
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

            if(HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                string firstVisitedDateTime = HttpContext.Request.Cookies["first_request"];
                // Cookie exists
                data = "Welcome back " + firstVisitedDateTime;
            }
            else
            {
                // Create a cookie for one day life time
                CookieOptions options = new CookieOptions();
                options.Expires = DateTimeOffset.UtcNow.AddDays(1);
                // Cookie does not exist
                data = "You visited First time";
                HttpContext.Response.Cookies.Append("first_request", System.DateTime.Now.ToString(), options);
            }
            
            // Check if the cookie exists
            return View("index", data);
        }

        public IActionResult Remove()    // add /home/remove to remove the cookie from the website
        {
            string confirmationMsg = "The COokie is removed ...";
            HttpContext.Response.Cookies.Delete("first_request");
            return View("Index", confirmationMsg);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
