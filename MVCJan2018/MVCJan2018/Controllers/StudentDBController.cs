using MVCJan2018.Infrastrcture;
using MVCJan2018.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJan2018.Controllers
{
    public class StudentDBController : Controller
    {
        MVCDBContext dbContext = new MVCDBContext();
        // GET: StudentDB
        public ActionResult Index()
        {
            List<Student> studentList = dbContext.Student.ToList();
            return View(studentList);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student studentObj)
        {
            dbContext.Student.Add(studentObj);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Student studentObj = dbContext.Student.First(i => i.Id == id);
            return View(studentObj);
        }

        [HttpPost]
        public ActionResult Edit(Student studentObj)
        {
            dbContext.Entry(studentObj).State = EntityState.Modified;
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Student studentObj = dbContext.Student.First(i => i.Id == id);
            dbContext.Student.Remove(studentObj);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}