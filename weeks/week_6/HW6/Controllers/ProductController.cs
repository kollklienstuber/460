using System;
using System.Net;
using System.Web.Mvc.Html;
using System.Web.Mvc;
using System.Linq;

namespace HW6.Controllers
{
    public class ProductController : Controller
    {
        private Models.AdventureWorks db = new Models.AdventureWorks();
        
        public ActionResult Index(int? id)
        {
            //if a product category was selected then throw into viewbag.
            var prodCategories = db.ProductCategories;
            if (id != null && db.ProductCategories.Find(id) != null)
            {
                ViewBag.ID = id;
            }
            //return view
            return View(prodCategories);
        }

        //httpget request to determine the id that was given for what review 
        //then sends review for a product if correctly completed.
        [HttpGet]
        public ActionResult Review(int? id)
        {
            int productid = id ?? -1;
            if (productid == -1) 
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var productTitle = db.Products.Find(productid);
            if (productTitle == null) 
                return HttpNotFound();

            //data created for a review that needs to be sent
            Models.ProductReview review = db.ProductReviews.Create();
            review.Product = productTitle;
            review.ProductID = productid;
            review.ReviewDate = DateTime.Now;
            review.ModifiedDate = review.ReviewDate;           

            return View(review);
        }


        [HttpPost]
        public ActionResult Review(Models.ProductReview review)
        {
            //check to see if the data we get is valid
            //if the data is valid then sent it to the database where it can be stored and returned 
            if (ModelState.IsValid)
            {
                db.ProductReviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("IndividualProduct", new { id = review.ProductID });
            }
            review.Product = db.Products.Find(review.ProductID);
            return View(review);
        }



        public ActionResult MultiProducts(int? id, int? page = 1)
        {
            if (id == null || db.ProductSubcategories.Find(id) == null)
                return RedirectToAction("Index"); 

            var products = db.ProductSubcategories.Find(id).Products.ToList();
               //determine the number of pages total and the amount of items maximum per page here
            int pageSize = 6;
            double numOfPages = Math.Ceiling((double)products.Count / pageSize); 

           int pageNumber = page ?? 1;
          
            ViewBag.NumberOfPages = numOfPages;

            // getting the items determined by the page numbers
            var productPaged = products.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            return View(productPaged);
        }


        public ActionResult ViewReviews(int? id)
        {
            var rev = db.ProductReviews;

            return View(rev);
        }


        public ActionResult IndividualProduct(int? id)
        {
            // for cases where product id was not given
            if (id == null) 
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = db.Products.Find(id);

            // for cases where an entity doesnt exist
            if (product == null) 
                return HttpNotFound();

            // if exists then determine the size measurement
            var sizeUnit = product.SizeUnitMeasureCode;
            ViewBag.SizeUnit = sizeUnit == null ? "N/A" : product.SizeUnitMeasureCode.ToLower();

            // if exists then determine the weight measurement
            var weightUnit = product.WeightUnitMeasureCode;
            ViewBag.WeightUnit = weightUnit == null ? "N/A" : product.WeightUnitMeasureCode.ToLower();
            return View(product);
        }


        public ActionResult ProductPhoto(int? id, bool? photo)
        {
            int ID;
            if (int.TryParse(id.ToString(), out ID)) { }
            var img = db.ProductProductPhotoes.Where(product => product.ProductID == ID).FirstOrDefault().ProductPhoto.LargePhoto;
            return File(img, "image/trees");
        }
    }
}