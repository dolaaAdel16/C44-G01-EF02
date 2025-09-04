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
    internal class DepartmnetConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.Id);
            D.Property(D => D.Id).UseIdentityColumn(10, 10);
            D.Property(D => D.Name)
                 .HasColumnName("Name")
                 .HasColumnType("varchar")
                 .HasMaxLength(50)
                 .IsRequired();
            
        }
    }
}
