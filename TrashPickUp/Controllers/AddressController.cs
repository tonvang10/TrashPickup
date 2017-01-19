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
            return View();
        }
        // GET: Address/Create
        public ActionResult Index(Customer plan)
        {
            db.Customers.Add(plan);
            db.SaveChanges();
            
            return View();
        }

        //// POST: Address/Create
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
    }
}
