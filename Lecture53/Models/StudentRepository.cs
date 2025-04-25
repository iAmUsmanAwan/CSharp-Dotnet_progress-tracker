namespace Lecture50.Models
{
    static public class StudentRepository
    {
        public static List<Student> Students = new List<Student>();

        static StudentRepository() 
        {
            Students.Add(new Student { Id = 1, Name = "Ali", Age = 20, CGPA = 3.5f, Semester = "8th" });
            Students.Add(new Student { Id = 2, Name = "Ahmed", Age = 21, CGPA = 3.6f, Semester = "8th" });
            Students.Add(new Student { Id = 3, Name = "Khalid", Age = 22, CGPA = 3.7f, Semester = "8th" });
            Students.Add(new Student { Id = 4, Name = "Umer", Age = 23, CGPA = 3.8f, Semester = "8th" });
            Students.Add(new Student { Id = 5, Name = "Haider", Age = 24, CGPA = 3.9f, Semester = "8th" });
        }  

        public static void AddStudent(Student s)
        {
            Students.Add(s);
        }
    }
}