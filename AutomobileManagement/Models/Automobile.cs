using System.ComponentModel.DataAnnotations;

namespace AutomobileManagement.Models
{
    public class Automobile
    {
        [Required]
        public int VehicleID { get; set; }

        [Required(ErrorMessage = "Vehicle Name is required")]
        [StringLength(30)]
        public string VehicleName { get; set; }

        [Required(ErrorMessage = "This section is required")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "This section is required")]
        [Range(2000, 2035)]
        public int ModelYear { get; set; }

        [Required(ErrorMessage = "This section is required")]
        [Range(10000, 10000000)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "This section is required")]
        public string FuelType { get; set; }
    
}
}
