using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashPickUp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TrashPickUp.DAL
{
    public class TrashContext : DbContext
    {

        public TrashContext() : base("TrashContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}