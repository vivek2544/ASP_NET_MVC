using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View(new SearchEmployee());
        }

        public ActionResult ListEmployees(Employee[] searchedResult)
        {
            return View(searchedResult);
        }
    }
}
