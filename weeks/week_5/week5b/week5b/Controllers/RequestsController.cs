using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week5b.Models;
using week5b.DAL;
using System.Data.Entity;
using System.Net;

namespace week5b.Controllers
{
    public class RequestsController : Controller
    {
         //db variable
        private DAL.FormContext db = new DAL.FormContext();
        // GET: Forms
        public ActionResult Index()
        {
            return View(db.Requests.ToList());
        }

        // GET: Forms/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request form = db.Requests.Find(id);
            if (form == null)
            {
                return HttpNotFound();
            }
            return View(form);
        }

        // GET: Forms/Create
        public ActionResult Create()
        {
            return View();
        }


        // GET: Forms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request form = db.Requests.Find(id);
            if (form == null)
            {
                return HttpNotFound();
            }
            return View(form);
        }


        // POST: Forms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID, PName, DOB, City, PAddress, State, Zip, County")] Request form)
        {
            if (ModelState.IsValid)
            {
                db.Requests.Add(form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(form);
        }

        // POST: Forms/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,DOB")] Request form)
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
