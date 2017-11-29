using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
using hw8.Models;

namespace hw8.Controllers
{
    public class HomeController : Controller
    {

        //remember to include hw8.Models;
        private dbContext db = new dbContext();
        //returns index view of our mostly blank homepage that links to other pages
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ArtWorks()
        {

            return View(db.ArtWorks.ToList());
        }


        public ActionResult Artists()
        {

            return View(db.Artists.ToList());
        }


        //returns classifictions 
        public ActionResult Classifications()
        {
            return View(db.Classifications.ToList());
        }


       
    }
}