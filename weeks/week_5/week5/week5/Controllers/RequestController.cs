using week5.DAL;
using week5.Models;
using System.Linq;
using System.Web.Mvc;

namespace week5.Controllers
{
    public class RequestController : Controller
    {
        private System.Web.Mvc.FormContext db = new System.Web.Mvc.FormContext();

        public ActionResult Index()
        {
            return View(db.FormId.ToList());
        }

        [HttpPost]
        public ActionResult Create(Form request)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }
            return View(request);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

  

    }
}