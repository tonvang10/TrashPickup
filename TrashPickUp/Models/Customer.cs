using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickUp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public char daily { get; set; }
        public int pickup_day { get; set; }
        public DateTime vacation_start { get; set; }
        public DateTime vacation_end { get; set; }
        public double amount_owed { get; set; }
        public string address { get; set; }
    }
}
