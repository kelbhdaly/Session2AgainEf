using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session2Again.ModelConfiguration;
using Session2Again.Models;

namespace Session2Again.DbContexts
{
    internal class Session02Again : DbContext
    {
        public Session02Again() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = Session2Again ; Trusted_Connection =True ; TrustServerCertificate = True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



            //modelBuilder.Entity<Department>()
            //    .HasOne(D=> D.Manager)
            //    .WithOne(E=>E.DepartmentManage)
            //    .HasForeignKey<Department>(D=>D.DeptManagerId)

            //modelBuilder.Entity<Employee>()
            //    .HasOne(E => E.)
            //    .WithOne(E => E.Manager)
            //    .HasForeignKey<Department>(D => D.DeptManagerId);



            //modelBuilder.Entity<Employee>()
            //    .HasOne<Department>()
            //    .WithOne()
            //    .HasForeignKey<Department>(D => D.DeptManagerId);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
