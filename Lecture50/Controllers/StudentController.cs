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
            StudentRepository.AddStudent(s);
            return View("Thankx", s);
        }

        public ViewResult ListStudents()
        {
            return View(StudentRepository.Students);
        }


    }
}
