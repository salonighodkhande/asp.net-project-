using AutomobileManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutomobileManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Index(Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Automobile Registered Successfully";
                return View("Success", automobile);
            }

            return View();
        }
    }
}
