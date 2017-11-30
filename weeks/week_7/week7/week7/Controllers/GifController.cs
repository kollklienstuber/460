using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week7.Models;

namespace week7.Controllers
{
    public class GifController : Controller
    {
        private GifDBContext db = new GifDBContext;
        // GET: Gif
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Giphy(string query)
        {
            var URL = "http://api.giphy.com/v1/gifs/search?q=" + query + "&api_key=" + key + "&limit=" + limit;





        }
    }
}