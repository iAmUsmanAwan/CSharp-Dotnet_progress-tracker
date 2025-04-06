using Lecture58.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lecture58.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentRepository repo;
        public StudentController()
        {
            repo = new StudentRepository();
        }

        [HttpGet]
        public List<Student> Get()
        {
            return repo.GetAllStudents();
        }

    }
}
