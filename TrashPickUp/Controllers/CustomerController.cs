using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TrashPickUp.Models;

namespace TrashPickUp.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        private ApplicationDbContext db = new ApplicationDbContext();
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            //ViewData["testing"] = from c in _context.Customers select c;
            //var x = /*(from per in db.Customers select */new Customer() /*{ FirstName = per.FirstName, Zipcode = per.Zipcode, Login = per.Login }*/;
            var x = db.Customers;
            //var customers = db.Customers;


            return View(x);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit1(/*[Bind(Include = "ID,Street,ApartmentNumber,City,State,ZipCode")] */Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                //db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }
}