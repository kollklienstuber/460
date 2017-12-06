using System;
using System.Collections.Generic;
using FinalFix.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

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



        //itemread----------------------------------------------itemread--------------------------------


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
            ViewBag.ItemSeller = item.Seller;
            ViewBag.ItemDescription = item.ItemDescription;
            var items = db.Items.Where(c => c.ItemID == id).Select(c => c.ItemName);

            return View(item);
        }


        //item Update-----------------------------------------------item Update-----------------------------
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemID, ItemName, ItemDescription, SellerName")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Items");
            }
            return View(item);
        }


        //item delete-----------------------------------------------item delete-----------------------------

        public ActionResult ItemDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Delete
        [HttpPost, ActionName("ItemDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Items");
        }


        //item CREATE-----------------------------------------------item CREATE-----------------------------

        // our get for creating an Item
        public ActionResult ItemCreate()
        {
            return View();
        }

        //post item
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ItemCreate([Bind(Include = "ItemID, ItemName, ItemDescription, SellerName")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("Items");
            }

            return View(item);
        }




        //BIDS----------------------------------------------------bids---------------------------


        //GET bid
        public ActionResult BidCreate()
        {
            return View();
        }

        //POST bid
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BidCreate([Bind(Include = "ItemID, BuyerName, PriceOfItem, TimeOfBid")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Items");
            }

            return View(bid);
        }

    








    }
}