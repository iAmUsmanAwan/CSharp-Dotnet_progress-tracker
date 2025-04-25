using Microsoft.AspNetCore.Mvc;
using Lecture50.Models;

namespace Lecture50.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Remove(int id)
        {
            Student s = StudentRepository.Students.Find(s => s.Id == id);
            StudentRepository.Students.Remove(s);
            return View("ListStudents", StudentRepository.Students);
        }

        public ViewResult Details(int id)
        {
            Student s = StudentRepository.Students.Find(s => s.Id == id);
            return View("Thankx", s);
        }

        public ViewResult Edit(int id)
        {
            Student s = StudentRepository.Students.Find(s => s.Id == id);
            return View("Edit", s);
        }

        [HttpPost]
        public ViewResult Edit(Student s)
        {
            if (ModelState.IsValid)
            {
                foreach (Student std in StudentRepository.Students)
                {
                    if (std.Id == s.Id)
                    {
                        std.Name = s.Name;
                        std.Age = s.Age;
                        std.CGPA = s.CGPA;
                        std.Semester = s.Semester;
                        break;
                    }
                }
                return View("ListStudents", StudentRepository.Students);
            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please correct the Data");
                return View();
            }
        }

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
            else
            {
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