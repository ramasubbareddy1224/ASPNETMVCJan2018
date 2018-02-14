using BusinessService;
using MVCJan2018.Infrastrcture;
using MVCJan2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJan2018.Controllers
{

    public class ProductController : Controller
    {
        private EmployeeService _empService;
        public ProductController()
        {
            _empService = new EmployeeService();
        }
        public string Print()
        {
            return "Pragim Tech";
        }

        public string ShowName(string id)
        {
            // string id = RouteData.Values["id"].ToString();
            return "This is Rama with id:" + id;
        }
        [CustomActionFilter]
        [AllowAnonymous]
        public ActionResult Info(string id)
        {
            // throw new Exception("user exception");

            ViewData["Name"] = "Rama";
            ViewData["Email"] = "rama@gmail.com";
            ViewData["Date"] = DateTime.Now;

            ViewBag.VBName = "Siva";
            ViewBag.VBEmail = "siva@gmail.com";
            ViewBag.VBDate = DateTime.Now;

            if (id == "redirect")
            {
                TempData["TDName"] = "Temp Data Name";
                // return RedirectToAction("Info2");
                return RedirectToAction("Info2", "Product");
            }

            return View();
        }
        public ActionResult Info2()
        {
            string tempVale = TempData["TDName"].ToString();
            //TempData.Keep();
            //return RedirectToAction("Content", "Product");
            return View();
        }

        [NonAction]
        public ActionResult Content()
        {
            return Content("This is content type");
        }


        public ActionResult RazorView()
        {
            return View();
        }

        [ChildActionOnly]
        public string GetInternalConfig()
        {
            return "XSDSDS-WQWQQ";
        }

        public ActionResult Employee()
        {
            ViewBag.Title = "Employee Title";
            EmployeeVM empObj = new EmployeeVM
            {
                Id = 1,
                Name = "Rama",
                Email = "rama@gmail.com",
                Address = "Hyd",
                Department = new DepartmentVM { Id = 10, Name = "Computer" }
            };
            return View(empObj);
        }
        public ActionResult EmpDept()
        {
            ViewBag.Title = "Employee Dept Title";
            EmployeeVM empObj = new EmployeeVM
            {
                Id = 1,
                Name = "Rama",
                Email = "rama@gmail.com",
                Address = "Hyd",
            };

            DepartmentVM DeptObj = new DepartmentVM { Id = 10, Name = "Computer" };

            EmployeeDeptVM MainObj = new EmployeeDeptVM()
            {
                Employee = empObj,
                Department = DeptObj
            };


            //MainObj.Employee = empObj;
            //MainObj.Department = DeptObj;

            return View(MainObj);
        }
        public ActionResult EmployeeList()
        {
            List<EmployeeVM> empList = new List<EmployeeVM>();
            EmployeeVM empObj = new EmployeeVM()
            {
                Id = 1,
                Name = "Rama",
                Email = "rama@gmail.com",
                Address = "Hyd"
            };
            EmployeeVM empObj2 = new EmployeeVM()
            {
                Id = 2,
                Name = "Siva",
                Email = "siva@gmail.com",
                Address = "Hyd"
            };

            empList.Add(empObj);
            empList.Add(empObj2);

            return View(empList);
        }

        public ActionResult json()
        {
            EmployeeVM empObj = new EmployeeVM()
            {
                Id = 1,
                Name = "Rama",
                Email = "rama@gmail.com",
                Address = "Hyd"
            };
            return Json(empObj, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductVM product)
        {
            if(ModelState.IsValid)
            {

            }
            return RedirectToAction("Employee");
        }


        //public ActionResult ProductPartial()
        //{
        //    return PartialView();
        //}

    }
}