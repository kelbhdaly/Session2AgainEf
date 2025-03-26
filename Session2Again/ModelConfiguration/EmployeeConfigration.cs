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
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Name)
                //.HasColumnName("EmpName")
                .HasMaxLength(50)
                .HasColumnType("Varchar")
                .IsRequired(false);

            builder.Property(E => E.Id).UseIdentityColumn(1,10);
        }
    }
}
