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



        //our get for creating an artist
        public ActionResult CreateArtist()
        {
            return View();
        }

        //post artist
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateArtist([Bind(Include = "ArtistID, ArtistName, ArtistDOB, ArtistCity")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(artist);
                db.SaveChanges();
                return RedirectToAction("Artists");
            }

            return View(artist);
        }


        //get artist details
        public ActionResult ArtistRead(int? id)
        {
            // if product id wasn't given
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //find our artist to use by id given
            var artist = db.Artists.Find(id);
        

            //place the data of the artists into a viewbag that we can use to return to user.
            ViewBag.ArtistName = artist.ArtistName;
            ViewBag.ArtistCity = artist.ArtistCity;
            ViewBag.ArtistDOB = artist.ArtistDOB;
            //store artworks where artist id equals FK of artworks.
            var Artwork = db.ArtWorks.Where(c => c.ArtistID == id).Select(c => c.Title);

            return View();
        }



        //returns classifictions 
        public ActionResult Classifications()
        {
            return View(db.Classifications.ToList());
        }


       
    }
}