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
            return View();   // if the action method and the view name is same then we dont need to pass the name of the view
        }
        public ViewResult Student() 
        {
            string myData = "This is the Dummy Data";
            return View("Student", myData);    // here we are sending this data to Student view
        }
    }
}
