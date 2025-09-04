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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
           
        
            S.HasKey(S => S.Id);
            S.Property(S => S.Id).UseIdentityColumn(10, 10);
            S.Property(S => S.FName)
                 .HasColumnName("Name")
                 .HasColumnType("varchar")
                 .HasMaxLength(50)
                 .IsRequired();
          
        
    }
    }
}
