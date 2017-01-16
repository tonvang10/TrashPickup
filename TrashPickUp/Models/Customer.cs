using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickUp.Models
{
    public class Customer
    {
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
    }
}