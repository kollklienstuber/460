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
        // returns the view for the home/index file
        public ActionResult Index()
        {
            return View();
        }
    }
}