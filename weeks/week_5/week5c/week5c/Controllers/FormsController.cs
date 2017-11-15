using System.Linq;
using week5c.Models;
using System;
using System.Web.Mvc;
using System.Data.Entity;
using week5c.DAL;
using System.Net;

namespace week5c.Controllers
{


    public class FormsController : Controller
    {


        private DAL.FormContext db = new DAL.FormContext();


        //returns the current set of dmv forms
        // GET: Forms
        public ActionResult Index()
        {
            return View(db.Forms.ToList());
        }

        // GET: Forms/Create
        //returns the view of the create dmv form page
        public ActionResult Create()
        {
            return View();
        }

        // POST: Forms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID, FirstName, LastName, DOB, City, NewAddress, NewState, Zip, County")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Forms.Add(form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(form);
        }

        // POST: Forms/Edit/5
        //validation and posts the new object created
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,DOB")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(form);
        }


    }
}
