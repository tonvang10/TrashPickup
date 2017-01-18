using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashPickUp.Models;
using Microsoft.AspNet.Identity;

namespace TrashPickUp.Models
{
    public class AddressController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Address
        public ActionResult Index()
        {
            

            return View(/*db.address.ToList()*/);
        }

        

        // GET: Address/Create
        public ActionResult Index(Customer plan)
        {
            db.Customers.Add(plan);
            db.SaveChanges();
            
            return View();
        }

        //// POST: Address/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Street,ApartmentNumber,City,State,ZipCode")] Address address)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.address.Add(address);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(address);
        //}

        // GET: Address/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Address address = db.address.Find(id);
        //    if (address == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(address);
        //}

        // POST: Address/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Street,ApartmentNumber,City,State,ZipCode")] Address address)
        {
            if (ModelState.IsValid)
            {
                db.Entry(address).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(address);
        }

        // GET: Address/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Address address = db.address.Find(id);
        //    if (address == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(address);
        //}

        // POST: Address/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Address address = db.address.Find(id);
        //    db.address.Remove(address);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        ////Create 3 action to get the view where we will show google map
        ////1. Index - for return view where i will show google map
        //public ActionResult Index()
        //{
        //    return View;
        //}
        ////2. GetAllLocation - for fetch all the location from database and show in the view
        //public JsonResult GetAllLocation()
        //{
        //    using (ApplicationDbContext db = new ApplicationDbContext())
        //    {
        //        var v = db.Locations.OrderBy(a => a.Title).ToList();
        //        return new JsonResult { Data = v, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        //    }
        //}
        ////3. GetMarkerInfo - for fetch location details from database for show marker in the map
        //public JsonResult GetMarkerInfo(int locationID)
        //{
        //    using (MyDatabaseEntities dc = new MyDatabaseEntities())
        //    {
        //        Location 1 = null;
        //        1 = dc.Locations.Where(a => a.LocationID.Equals(locationID)).FirstOrDefault();
        //        return new JsonResult { Data = 1, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        //    }
        //}
    }
}
