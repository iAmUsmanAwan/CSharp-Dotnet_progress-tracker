using Microsoft.AspNetCore.Mvc;

namespace Lecture48.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello from Index of Home Controller...";
        //}
        //public string Student()
        //{
        //    return "Hello from Student...";
        //}

        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Student() 
        {
            return View();
        }
    }
}
