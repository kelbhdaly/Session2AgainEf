using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session2Again.Models;

namespace Session2Again.ModelConfiguration
{

    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.ToTable("Department", "Sales");
            D.HasKey(D => D.Id);
            D.Property(D => D.Id)
                .UseIdentityColumn(10, 10);

            //D.Property(D => D.DeptId)
            //.ValueGeneratedNever(); // Disable Identity  Constraint 

            //D.Property(D => D.DeptId)
            //  .HasDefaultValueSql("NewGuid()");

            D.Property(D => D.DeptName)
            .HasColumnName("DeptName")
            .HasColumnType("varchar")
            .HasMaxLength(20)
            .HasDefaultValue("HR");


            D.Property(D => D.DateOfCreation)
            .HasDefaultValueSql("GetDate()")
            .HasAnnotation("DataType", "Data");
            //.HasDefaultValue("GetDate")//Default Value Is Date The First Migration
            //.HasComputedColumnSql("GetDate()");
            D.Ignore(D => D.Serial);
            D.OwnsOne(D => D.EmpAddress, Address => Address.WithOwner());
        }
    }
}
