using EF02Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02Assignment.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.HasKey(C => C.Id);
            C.Property(C => C.Id).UseIdentityColumn(10, 10);
            C.Property(C => C.Name)
                 .HasColumnName("Name")
                 .HasColumnType("varchar")
                 .HasMaxLength(50)
                 .IsRequired();
           
        }
    }
}
