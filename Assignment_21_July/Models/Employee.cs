namespace Assignment_21_July.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee name is mandatory")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Employee name must be atleast 3 letters and max 20 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Department is mandatory")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Student age is mandatory")]
        [Range(18000, 250000, ErrorMessage = "Employee must be between 18000 and 250000")]
        public long Salary { get; set; }

        [Required(ErrorMessage = "Employee email is mandatory")]
        [EmailAddress(ErrorMessage = "Email is incoreect , Enter a valid email id")]
        public string Email { get; set; }

    }
}
