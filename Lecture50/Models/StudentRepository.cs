namespace Lecture50.Models
{
    public class StudentRepository
    {
        public static List<Student> Students = new List<Student>();
        public static void AddStudent(Student s)
        {
            Students.Add(s);
        }
    }
}
