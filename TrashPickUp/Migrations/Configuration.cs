namespace TrashPickUp.Migrations
{
    using TrashPickUp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<TrashPickUp.Models.ApplicationDbContext>
    {
        protected override void Seed(TrashPickUp.Models.ApplicationDbContext context)
        {
            var students = new List<Customer>
            {
                new Customer { Login = "Jason", Password = "password", Address = "3807 Nagawicka Shores Drive", State = "WI", Zipcode = "53029", AmountOwed = 45.32,
                    OnVacation = "N", CustomerID = 1, VacationEnd = null, VacationStart = null}
            };
            students.ForEach(s => context.Customers.AddOrUpdate(p => p.Login, s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee {EmployeeID = 1, Login = "Bert", Password = "password"}
            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.Login, s));
            context.SaveChanges();

            var admins = new List<Admin>
            {
                 new Admin {AdminID = 1, Login = "Admin", Password = "password"
                 }
            };
            admins.ForEach(s => context.Admins.AddOrUpdate(p => p.Login, s));
            context.SaveChanges();

        }
    }
}
