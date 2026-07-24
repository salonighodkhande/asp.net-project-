using Microsoft.AspNetCore.Mvc;
using Project_21_July1.Models;
using System.Diagnostics;

namespace Project_21_July1.Controllers
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
        public ActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Student " + student.Name + "registered succesfully in college";
            }
            return View(student);
        }
        
    }
}
