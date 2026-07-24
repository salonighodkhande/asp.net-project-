using System.ComponentModel.DataAnnotations;

namespace Project_21_July1.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student name is mandatory")]
        [StringLength(20,MinimumLength=3, ErrorMessage = "Student name must be atleast 3 letters and max 20 letters")]
        public string name { get; set; }

        [Required(ErrorMessage = "Student age is mandatory")]
        [Range(18,25, ErrorMessage = "Stdent age must be between 18 nd 25")]
        public int age { get; set; }

        [Required(ErrorMessage = "Student email is mandatory")]
        [EmailAddress(ErrorMessage ="Email is incoreect , Enter a valid email id")]
        public string email { get; set; }

        [Required(ErrorMessage = "Student course is mandatory")]
        public string course { get; set; }
    }
}