using Microsoft.AspNetCore.Mvc;

namespace Lecture49.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            string myName= "John Wick";
            return View("Index", myName);
        }

        [HttpGet]
        public ViewResult StudentForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StudentForm(string name, string age, string cgpa, string semester)
        {
            return View();
        }

    }
}
