
using Microsoft.AspNetCore.Mvc;

namespace Lecture48.Controllers
{
    public class StudentController : Controller
    {
        //public string Index()
        //{
        //    return "This is a Student Controller...";    // Displaying a simple string message
        //}

        public ViewResult Index()
        {
            return View("Index");     // displaying a Html page created in Views/Student/Index.cshtml
        }   
    }
}
