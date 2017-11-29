using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ArtWorks()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Artists()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }



        public ActionResult Classifications()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
    }
}