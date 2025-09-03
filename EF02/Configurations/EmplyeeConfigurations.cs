using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configurations
{
    internal class EmplyeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
           E.HasKey(E => E.Id);
           E.Property(E => E.Id).UseIdentityColumn(10, 10);
           E.Property(E => E.Name)
                .HasColumnName("EmployeeName")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(); 
            E.Property(E => E.Salary).HasColumnType("decimal(18,2)")
                .IsRequired(false);
        }
    }
}
