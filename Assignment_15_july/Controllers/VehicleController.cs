using Microsoft.AspNetCore.Mvc;
using Assignment_15_july.Models;

namespace Assignment_15_july.Controllers
{
    public class VehicleController : Controller
    {
        // List to store vehicles temporarily
        public static List<Vehicle> vehicles = new List<Vehicle>();

        // Display all vehicles
        public IActionResult Index()
        {
            return View(vehicles);
        }
    }
}   
