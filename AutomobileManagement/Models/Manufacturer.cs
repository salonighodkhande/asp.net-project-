using System.ComponentModel.DataAnnotations;

namespace AutomobileManagement.Models
{
  
        public class Manufacturer
        {
            [Required(ErrorMessage = "Manufacturer Name is required")]
            public string ManufacturerName { get; set; }

            [Required(ErrorMessage = "Country is required")]
            public string Country { get; set; }

            [Required(ErrorMessage = "Contact Number is required")]
            [Phone(ErrorMessage = "Enter a valid contact number")]
            public string ContactNumber { get; set; }

            [Required(ErrorMessage = "Email Address is required")]
            [EmailAddress(ErrorMessage = "Enter a valid email address")]
            public string EmailAddress { get; set; }
        
    }
}
