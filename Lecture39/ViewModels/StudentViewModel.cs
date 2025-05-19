using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture39.Commands;
using Lecture39.Models;

namespace Lecture39.ViewModels
{
    class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        StudentService studentService;

        public DelegateCommand AddCommand { get; set; } 

        public StudentViewModel()
        {
            studentService = new StudentService();
            
            Students = studentService.GetAllStudents();
            AddCommand = new DelegateCommand(Add, canAdd);
        }

        public void Add(object o)
        {
            Student s = new Student();
            s.Id = this.Id;
            s.Name = this.Name;
            s.Age = this.Age;
            studentService.AddStudent(s);
        }

        public bool canAdd(object o)
        {
            if (string.IsNullOrEmpty(Id.ToString()) ||
                string.IsNullOrEmpty(Name) || 
                string.IsNullOrEmpty(Age.ToString()))
            {
                return false;
            }
            return true;
        }   

    }
}
