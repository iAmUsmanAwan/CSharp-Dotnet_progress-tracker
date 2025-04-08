using System.Collections.Generic;

namespace Lecture59.Models
{
    public class StudentRepository
    {
        List<Student> students;
        public StudentRepository()
        {
                students = new List<Student>()
                {
                    new Student { Id = 1, Name = "John Wick", Age = 20 },
                    new Student { Id = 2, Name = "Jason Statham", Age = 22 },
                    new Student { Id = 3, Name = "Tom Braddy", Age = 19 }
                };
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
        public Student GetStudentById(int id)
        {
            return students.Find(s => s.Id == id);
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void UpdateStudent(Student updatedStudent)
        {
            var existingStudent = students.Find(s => s.Id == updatedStudent.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = updatedStudent.Name;
                existingStudent.Age = updatedStudent.Age;
            }
        }

        public void DeleteStudent(int id)
        {
            var student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
        }


    }
}
