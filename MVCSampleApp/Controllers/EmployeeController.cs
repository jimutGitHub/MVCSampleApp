using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleApp.Models;

namespace MVCSampleApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            Employee employee = empContext.Employees.Single(emp => emp.Id == id);
            return View(employee);
        }
    }
}