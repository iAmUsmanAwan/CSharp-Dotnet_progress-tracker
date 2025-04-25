using Microsoft.AspNetCore.Mvc;

namespace Lecture51.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
