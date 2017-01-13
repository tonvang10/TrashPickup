namespace TrashPickUp.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrashPickUp.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<TrashPickUp.DAL.TrashContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrashPickUp.DAL.TrashContext context)
        {
            var customers = new List<Customer>
            {
                new Customer { customer_ID = 1, login = "Jason",   password = "password",
                    daily = "Y", pickup_day = 1, vacation_start = null, vacation_end = null,
                    amount_owed = 25.67, address = "3807 Nagawicka Shores Drive", city = "Hartland",
                    state = "WI", zipcode = "53209", on_vacation = "N"},
           };
            customers.ForEach(s => context.Customers.AddOrUpdate(p => p.login, s));
            context.SaveChanges();

        var employees = new List<Employee>
            {
                new Employee {employee_ID = 1, login = "Bert", password = "password" }

            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.login, s));
            context.SaveChanges();

            var admins = new List<Admin>
            {
                new Admin {admin_ID = 1, login = "Admin", password = "password"},
            };

            admins.ForEach(s => context.Admins.AddOrUpdate(p => p.login, s));

            context.SaveChanges();
        }
    }
}
