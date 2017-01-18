using TrashPickUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace TrashPickUp.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Employee
        public EmployeeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var x = db.Customers;

            return View(x);
        }
        public ActionResult Details(int EmployeeID)
        {
            var player = _context.Employees.Include(m => m.Login).SingleOrDefault(m => m.EmployeeID == EmployeeID);

            return View(player);
        }
    }
}