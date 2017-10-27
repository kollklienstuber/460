using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week5.Models;
using static week5.Models.Database;

namespace week5.Controllers
{
    public class DatabaseController : Controller
    {
        private EmpDBContext db = new EmpDBContext();

        // GET: Database

        public ActionResult Index()
        {
            var employees = from e in db.Databases
                            orderby e.ID
                            select e;
            return View(employees);
        }


        public static List<Database> empList = new List<Database>
        {
      new Database{
         ID = 1,
         Name = "Allan",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 23
      },

      new Database{
         ID = 2,
         Name = "Carson",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 45
      },

      new Database{
         ID = 3,
         Name = "Carson",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 37
      },

      new Database{
         ID = 4,
         Name = "Laura",
         JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
         Age = 26
      },
   };



        // GET: Database/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Database/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Database/Create
        [HttpPost]
        public ActionResult Create(Database emp)
        {
            try
            {
                db.Databases.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Database/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Database/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Database/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Database/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
    }
}
