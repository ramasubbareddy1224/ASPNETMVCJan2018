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
        public ActionResult Info()
        {
            return View("info1");
        }

        public ActionResult Content()
        {
            return Content("This is content type");
        }
         
    }
}