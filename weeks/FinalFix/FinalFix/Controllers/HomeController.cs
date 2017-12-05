using System;
using System.Collections.Generic;
using FinalFix.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace FinalFix.Controllers
{
    public class HomeController : Controller
    {

        private AuctionDBContext db = new AuctionDBContext();

        public ActionResult Index()
        {
            return View();
        }

        //items----------------------------------------------items--------------------------------
        public ActionResult Items()
        {
            return View(db.Items.ToList());

        }


        //itemRead



        //get artist details
        public ActionResult ItemRead(int? id)
        {
            // First look at it the id wasnt even given
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //if they are given then we search and find by PK item id
            var item = db.Items.Find(id);


            //using viewbags to palce the given items information to return later to user.
            ViewBag.ItemName = item.ItemName;
            ViewBag.ItemDescription = item.ItemDescription;
            ViewBag.ItemSeller = item.Seller;



            var items = db.Items.Where(c => c.ItemID == id).Select(c => c.ItemName);

            return View(item);
        }



        //item delete-----------------------------

        // GET: Delete
        public ActionResult ItemDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item Items = db.Items.Find(id);
            if (Items == null)
            {
                return HttpNotFound();
            }
            return View(Items);
        }


        //Post delete
        [HttpPost, ActionName("ItemDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item items = db.Items.Find(id);
            db.Items.Remove(items);
            db.SaveChanges();
            return RedirectToAction("Items");
        }









        //bids----------------------------------------------------bids---------------------------


        // our get for creating an artist
        public ActionResult BidCreate()
        {
            return View();
        }

        //post artist
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BidCreate([Bind(Include = "BidID, Bid, ArtistDOB, ArtistCity")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bid);
        }




    }
}