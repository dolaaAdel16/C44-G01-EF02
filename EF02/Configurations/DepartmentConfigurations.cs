using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(D => D.Id).UseIdentityColumn(100, 100);
            builder.Property(D => D.DeptName).HasColumnName("DepartmentName")
                                             .HasColumnType("varchar")
                                             .HasMaxLength(50);
        }
    }
}
