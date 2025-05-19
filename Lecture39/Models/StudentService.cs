using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture39.Models
{
    class StudentService
    {
        ObservableCollection<Student> studentList; 
        
        public StudentService()
        {
            studentList = new ObservableCollection<Student>();
            studentList.Add(new Student() { Id = 1, Name = "Muhammad", Age = 40 });
            studentList.Add(new Student() { Id = 2, Name = "Ali", Age = 13 });
            studentList.Add(new Student() { Id = 3, Name = "Hussain", Age = 10 });
        }

        public void AddStudent(Student s)
        {
            studentList.Add(s); 
        }

        public ObservableCollection<Student> GetAllStudents()
        {
            return studentList;
        }

    }
}
