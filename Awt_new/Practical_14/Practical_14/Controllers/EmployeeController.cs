using Practical_14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_14.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<Employee> _employees = new List<Employee>();
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            return View(_employees);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Id = _employees.Count > 0 ? _employees.Max(e => e.Id) + 1 : 1;
                _employees.Add(employee);
                TempData["Message"] = "Employee added successfully";
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}