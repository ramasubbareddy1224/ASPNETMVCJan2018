using MVCJan2018.Infrastrcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJan2018.Controllers
{
   
    public class ProductController : Controller
    {
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
        //public ActionResult ProductPartial()
        //{
        //    return PartialView();
        //}

    }
}