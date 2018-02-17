using MVCJan2018.Infrastrcture;
using MVCJan2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCJan2018.Controllers
{
    public class AccountController : Controller
    {
        MVCDBContext dbContext = new MVCDBContext();
        // GET: Account
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Users userObj)
        {
            var data = dbContext.User.FirstOrDefault(i => i.Email == userObj.Email && i.Password == userObj.Password);
            if (data != null)
            {
                Session["UserSession"] = data;
                FormsAuthentication.SetAuthCookie(userObj.Email, false);
                return RedirectToAction("Index", "StudentDB");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");

        }
    }
}