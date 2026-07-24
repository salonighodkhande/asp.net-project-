using Microsoft.AspNetCore.Mvc;
using Assignment_21_July.Models;
using System.Diagnostics;

namespace Assignment_21_July.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Register()
        {
            //display form
            return View();
        }

        // handle form submission
        [HttpPost]
        public ActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {
                TempData["EmployeeName"] = employee.name;
            }
            return View(employee);
        }

    }
}
