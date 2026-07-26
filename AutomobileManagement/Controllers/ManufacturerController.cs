using Microsoft.AspNetCore.Mvc;
using AutomobileManagement.Models;

namespace AutomobileManagement.Controllers
{
    public class ManufacturerController : Controller
    {
       
            // GET
            public IActionResult Index()
            {
                Manufacturer manufacturer = new Manufacturer()
                {
                    ManufacturerName = "Tata Motors",
                    Country = "India",
                    ContactNumber = "9876543210",
                    EmailAddress = "info@tatamotors.com"
                };

                return View(manufacturer);
            }
        }
}