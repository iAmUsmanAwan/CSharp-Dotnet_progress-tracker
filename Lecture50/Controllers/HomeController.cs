using Microsoft.AspNetCore.Mvc;

namespace Lecture50.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
