using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OfficeChecker.Models;

namespace OfficeChecker.Data
{
    public class OfficeContext : DbContext
    {
        public OfficeContext (DbContextOptions<OfficeContext> options)
            : base(options)
        {
        }

        public DbSet<Office> Offices { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Office>().ToTable("Office");
            //modelBuilder.Entity<Employee>().ToTable("Employee");
            
        }

        public DbSet<OfficeChecker.Models.Office> Office { get; set; }
    }
}