using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickUp.Models;

namespace TrashPickUp.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllLocation()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var v = db.Addresses.OrderBy(a => a.ID).ToList();
                return new JsonResult { Data = v, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
        public JsonResult GetMarkerInfo(int locationID)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Address l = null;
                l = db.Addresses.Where(a => a.ID.Equals(locationID)).FirstOrDefault();
                return new JsonResult { Data = l, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
    }
}