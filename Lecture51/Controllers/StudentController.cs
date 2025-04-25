using Microsoft.AspNetCore.Mvc;
using Lecture50.Models;

namespace Lecture50.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult StudentForm()
        {
                return View();
        }

        [HttpPost]
        public ViewResult StudentForm(Student s)
        {
            if (ModelState.IsValid)
            {
                StudentRepository.AddStudent(s);
                return View("Thankx", s);
            }
            else {
                ModelState.AddModelError(String.Empty, "Please correct the Data");
                return View();
            }
        }

        public ViewResult ListStudents()
        {
            return View(StudentRepository.Students);
        }


    }
}