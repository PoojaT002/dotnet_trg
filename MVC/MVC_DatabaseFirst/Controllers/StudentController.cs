using MVC_DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DatabaseFirst.Controllers
{
    public class StudentController : Controller
    {
        infinitedbEntities2 db = new infinitedbEntities2();
        // GET: Student
        public ActionResult Index()
        {
            //1. The below action method uses scaffolded view
            List<Student> studlist = db.Students.ToList();
            return View(studlist);
        }


        ////2. the below action method does not use scaffolded view
        //public ActionResult GetCategoryDetails()
        //{
        //    List<Student> catlist = db.Students.ToList();
        //    return View(catlist);
        //}

        ////3. Adding or inserting a new category
        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(Student Students) // passing data from view to controller thru model object 
        //{
        //    db.Categories.Add(Student);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Delete(int Id)
        //{
        //    Students c = db.Categories.Find(Id);
        //    return View(c);
        //}
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteCategory(int Id)
        //{
        //    Category cat = db.Categories.Find(Id);
        //    db.Categories.Remove(cat);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}

