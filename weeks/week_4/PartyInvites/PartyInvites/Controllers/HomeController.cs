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
            decimal curLifeSpan = 79;
            decimal percentLeft = age / curLifeSpan;
            decimal lifeLeft = curLifeSpan - age;
            decimal b = Decimal.Parse(percentLeft.ToString("#.00"));

            return Content($"{name} if you are currently {age} years old and plan to" +
                $" live to be the age of an average" +
                $"american (79 years old) then you have {lifeLeft} years left to live! To put it" +
                $" in a different perspective you have lived {b} percent of your life.");

        }

        [HttpGet]
        public ActionResult Macros()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Macros(FormCollection form)
        {
            string name = Request.Form["name"];
            int age = Int32.Parse(Request.Form["age"]);
            int weight = Int32.Parse(Request.Form["weight"]);

            double protien;
            double fat;


            string gender = Request.Form["gender"];

            if (gender == "Female" || gender == "f" || gender == "F" ||gender ==  "female") {
                protien = weight / 1.7;
                protien = Math.Round(protien, 2);

                fat = weight * 0.35;
                ViewBag.caloriesToEat = ($"{name}Based on your information you should eat {protien} grams of protein, {fat} grams of fat, and fill the rest with carbs or eat kit kats. I'm not a doctor");
            }

            else
            protien = weight / 1.4;
            protien = Math.Round(protien, 2);

            fat = weight * 0.4;
            ViewBag.caloriesToEat = ($"{name} Based on your information you should eat {protien} grams of protein, {fat} grams of fat, and fill the rest with carbs or eat kit kats. I'm not a doctor");


            return View();
        }
        
    }
}