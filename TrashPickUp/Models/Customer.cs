using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashPickUp.Models
{
    //public class Customer : DbContext
    //{
    //    public DbSet<Customer> Customers { get; set; }
        
    //}

    public class Customer 
    {
        [Key]
        public int CustomerID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string OnVacation { get; set; }
        public string VacationStart { get; set; }
        public string VacationEnd { get; set; }
        public double AmountOwed { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PickupDay { get; set; }
        public string PhoneNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public string UserRoles { get; set; }
    }
}