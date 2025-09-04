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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
           
        
            I.HasKey(I => I.Id);
            I.Property(I => I.Id).UseIdentityColumn(10, 10);
            I.Property(I => I.Name)
                 .HasColumnName("Name")
                 .HasColumnType("varchar")
                 .HasMaxLength(50)
                 .IsRequired();
            I.Property(E => E.Salary).HasColumnType("float")
                .IsRequired(false);
        
    }
    }
}
