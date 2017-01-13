using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrashPickUp.Models
{
    public class Customer
    {
        [Key]
        public int customer_ID { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string daily { get; set; }
        public int pickup_day { get; set; }
        public string vacation_start { get; set; }
        public string vacation_end { get; set; }
        public double amount_owed { get; set; }
        public string address { get; set; }
        public string on_vacation { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
    }
}
