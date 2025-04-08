using Lecture59.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lecture59.Controllers
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

        [HttpGet("")] // Matches base route
        [HttpGet("get")] // Also matches get route
        public List<Student> Get()
        {
            return repo.GetAllStudents();
        }

        [HttpGet("{id}")] // Matches route with id    or we can use [Route("get/{id}")]
        public Student Get(int id)
        {
            return repo.GetStudentById(id);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] Student s)
        {
            if (s == null)
            {
                return BadRequest("Student is null");
            }
            repo.AddStudent(s);
            return Ok("Student added successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student s)
        {
            if (s == null || s.Id != id)
            {
                return BadRequest("Invalid student data");
            }

            // Find the student in the repository
            var existingStudent = repo.GetStudentById(id);

            if (existingStudent == null)   // If student doesn't exist, return 404 Not Found
            {
                return NotFound();
            }

            // Update the student's properties
            repo.UpdateStudent(s);

            return Ok("Student updated successfully");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = repo.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }

            repo.DeleteStudent(id);
            return Ok("Student deleted successfully");
        }


    }
}
