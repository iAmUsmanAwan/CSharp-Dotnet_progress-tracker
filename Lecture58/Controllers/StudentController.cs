using Lecture58.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lecture58.Controllers
{
    // we have made an api controller

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentRepository repo;
        public StudentController()
        {
            repo = new StudentRepository();
        }

        [HttpGet("")] // Matches base route
        [HttpGet("get")] // Also matches get route
        public List<Student> Get()
        {
            return repo.GetAllStudents();
        }

    }
}
