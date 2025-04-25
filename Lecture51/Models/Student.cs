using System.ComponentModel.DataAnnotations;
namespace Lecture50.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Age")]
        [Range(1, 100)]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please Enter CGPA")]
        public float? CGPA { get; set; }

        [Required(ErrorMessage = "Please Enter Semester")]
        public string Semester { get; set; }
    }
}