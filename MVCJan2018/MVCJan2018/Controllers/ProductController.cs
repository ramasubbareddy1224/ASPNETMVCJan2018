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

        public string ShowName()
        {
            return "This is Rama";
        }
    }
}