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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> T)
        {
         
        
            T.HasKey(T => T.Id);
            T.Property(T => T.Id).UseIdentityColumn(10, 10);
            T.Property(T => T.Name)
                 .HasColumnName("Name")
                 .HasColumnType("varchar")
                 .HasMaxLength(50)
                 .IsRequired();
           
        
    }
    }
}
