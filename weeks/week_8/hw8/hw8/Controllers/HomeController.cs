using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using hw8.Models;

namespace hw8.Controllers
{




    public class HomeController : Controller
    {
        //remember to include hw8.Models;
        private dbContext db = new dbContext();
        //returns index view of our mostly blank homepage that links to other pages
  

        //for returning artworks 
        public ActionResult ArtWorks()
        {

            return View(db.ArtWorks.ToList());
        }


        //for returning artists 

        public ActionResult Artists()
        {
            return View(db.Artists.ToList());
        }



        // our get for creating an artist
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


        // GET: Artists/Edit/
        public ActionResult ArtistUpdate(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ArtistUpdate([Bind(Include = "ArtistID,ArtistName,ArtistDOB,ArtistCity")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Artists");
            }
            return View(artist);
        }



        // GET: Delete
        public ActionResult ArtistDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist Artists = db.Artists.Find(id);
            if (Artists == null)
            {
                return HttpNotFound();
            }
            return View(Artists);
        }


        //Post delete
        [HttpPost, ActionName("ArtistDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artist artist = db.Artists.Find(id);
            db.Artists.Remove(artist);
            db.SaveChanges();
            return RedirectToAction("Artists");
        }



 


        //get artist details
        public ActionResult ArtistRead(int? id)
        {
            // First look at it the id wasnt even given
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //if they are given then we search and find by PK artist id
            var artist = db.Artists.Find(id);
        

            //using viewbags to palce the given artists information to return later to user.
            ViewBag.ArtistName = artist.ArtistName;
            ViewBag.ArtistCity = artist.ArtistCity;
            ViewBag.ArtistDOB = artist.ArtistDOB;

            // store artworks where artist id equals FK of artworks.
            var Artwork = db.ArtWorks.Where(c => c.ArtistID == id).Select(c => c.Title);

            return View(artist);
        }


        //returns classifictions 
        public ActionResult Classifications()
        {
            return View(db.Classifications.ToList());
        }




        public ActionResult Index(int? id)
        {
            var genreCategories = db.Genres;

            //make sure id isn't null
            if (id != null && db.Genres.Find(id) != null)
            {
                //store in viewbag
                ViewBag.ID = id;
            }
            return View(genreCategories);
        }

        public ActionResult Ajax(int? id)
        {
            //find the generid of the id passed in to work with.
            var data = db.Genres.Where(t => t.GenreID == id) 
                //find the data from classifications table
                .Select(t => t.Classifications)
                //order
                .First()
                //pull in title and artist
                .Select(t => new { t.ArtWork1.ArtistName, t.ArtWork1.Title })
                //order by title and send to list to return
                .OrderBy(t => t.Title)
                .ToList();
            //return Json object
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}