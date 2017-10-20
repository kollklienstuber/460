using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public ActionResult TempForm()
        {
            return View();
        }


        [HttpPost]
        [ActionName("TempForm")]
        public ActionResult Page1Post()
        {
            int age = Int32.Parse(Request.Form["age"]);
            string name = Request.Form["name"];
            int curLifeSpan = 79;
            int lifeLeft = curLifeSpan - age;
            return Content($"{name} if you are currently {age} years old and plan to live to be the age of an average american then you have " + lifeLeft + " years left to live!");

        }
    }
}