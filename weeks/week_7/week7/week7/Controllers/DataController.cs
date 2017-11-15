using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace week7.Controllers
{
    public class SimpleAPIController : Controller
    {
        // GET: SimpleAPI
        public ActionResult Index()
        {
            return View();
        }

        // GET: SimpleAPI/RandomNumbers/10
        public JsonResult RandomNumbers()
        {
           

            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}