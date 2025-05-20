using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture40.Commands;
using Lecture40.Models;

namespace Lecture40.ViewModels
{
    public class StudentViewModel
    {
        public Student SelectedStudent { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        StudentService studentService;

        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand RemoveCommand { get; set; }

        public StudentViewModel()
        {
            studentService = new StudentService();

            Students = studentService.GetAllStudents();
            AddCommand = new DelegateCommand(Add, canAdd);
            RemoveCommand = new DelegateCommand(Remove, canRemove);
        }

        public void Add(object o)
        {
            Student s = new Student();
            s.Id = this.Id;
            s.Name = this.Name;
            s.Age = this.Age;
            studentService.AddStudent(s);
        }

        public void Remove(object o)
        {
            if(SelectedStudent != null)
            { 
                studentService.RemoveStudent(SelectedStudent); 
            }
        }

        public bool canRemove(object o)
        {
            if (SelectedStudent != null)
            {
                return true;
            }
            else
            {
                return false;
            }
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
