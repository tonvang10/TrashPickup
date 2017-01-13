using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrashPickUp.Models
{
    public class Admin
    {
        [Key]
        public int admin_ID { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}