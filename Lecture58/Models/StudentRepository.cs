namespace Lecture58.Models
{
    public class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "John Wick", Age = 20 },
                new Student { Id = 2, Name = "Jason Statham", Age = 22 },
                new Student { Id = 3, Name = "Tom Braddy", Age = 19 }
            };
        }
    }
}
