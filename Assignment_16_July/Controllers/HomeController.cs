using Assignment_16_July.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_16_July.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Employeeid = 1, Name="Yeon Sieun", Department="Acting", Salary=100000, Email="sieun@gmail.com" },
                new Employee{Employeeid = 2, Name="Ahn Suho", Department="Acting/Modeling", Salary=150000, Email="suho@gmail.com" },
                new Employee{Employeeid = 3, Name="Park Hoo-min", Department="Management", Salary=150000, Email="baku@gmail.com" },
                new Employee{Employeeid = 4, Name="Go Hyun-tak", Department="Production", Salary=100000, Email="gotak@gmail.com" },
                new Employee{Employeeid = 1, Name="So Jun-tae", Department="Administrative", Salary=120000, Email="jun@gmail.com" }
            };
            return View(employees);
        }

        
    }
}
