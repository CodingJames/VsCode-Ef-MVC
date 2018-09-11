using System.Linq;
using EF03.EmpDataConText;
using EF03.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF03.Controllers {
    public class EmployeeController : Controller {
        private readonly AppDataContext context;
        public EmployeeController (AppDataContext context) {
            this.context = context;

        }

        [HttpGet]
        public IActionResult Index () {
            var emps = context.Employees.ToList ();
            return View (emps);
        }
        public IActionResult CreateEmployee () {
            return View ();
        }

        [HttpPost]
        public IActionResult AddEmployee (Employee emp) {
            if (!ModelState.IsValid) {
                return View (emp);
            }
            context.Add (emp);
            context.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult DeleteEmployee (int Id) {
            var emp = context.Employees.Find (Id);
            context.Employees.Remove (emp);
            context.SaveChanges ();

            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult EditEmployee (int Id) {
            var emp = context.Employees.Find (Id);
            return View (emp);
        }

        [HttpPost]
        public IActionResult UpdateEmployee (Employee emp) {
            if (!ModelState.IsValid) {
                return View (emp);
            }

            context.Employees.Update (emp);
            context.SaveChanges ();

            return RedirectToAction ("Index");
        }

    }
}