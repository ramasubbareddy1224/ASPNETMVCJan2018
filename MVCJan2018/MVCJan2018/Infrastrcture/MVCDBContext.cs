using MVCJan2018.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCJan2018.Infrastrcture
{
    public class MVCDBContext : DbContext
    {
        public MVCDBContext():base("MVCClassConnection")
        {
            Database.SetInitializer<MVCDBContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Student> Student { get; set; }
    }
}