using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;
namespace week5c.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}