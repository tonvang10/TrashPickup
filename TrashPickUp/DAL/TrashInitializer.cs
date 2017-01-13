using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TrashPickUp.Models;

namespace TrashPickUp.DAL
{

    public class TrashInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TrashContext>
    {
        protected override void Seed(TrashContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{customer_ID=1, login="Jason",password="password",daily="Y",pickup_day=1,vacation_start=null,vacation_end=null,on_vacation="N",amount_owed=45.67,address="3807 Nagawicka Shores Drive",city="Hartland",state="WI",zipcode="53029"}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
            var employees = new List<Employee>
            {
            new Employee{employee_ID=1,login="Bert",password="password"}
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
            var admins = new List<Admin>
            {
            new Admin{admin_ID=1,login="Admin",password="password"},

            };
            admins.ForEach(s => context.Admins.Add(s));
            context.SaveChanges();
        }
    }
}