using EF02Assignment.Configurations;
using EF02Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02Assignment.Contexts
{
    internal class ItIDbContext : DbContext
    {

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>().Property(E => E.Id).UseIdentityColumn(10, 10);
            //modelBuilder.Entity<Employee>().Property(E => E.Name)
            //    .HasColumnName("EmployeeName")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .IsRequired();    

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmnetConfiguration());
            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly())


            //modelBuilder.Entity<Employee>().HasOne(E => E.Department)
            //                               .WithOne(D => D.Manager)
            //                               .HasForeignKey<Department>(D => D.EmpId);

            //modelBuilder.Entity<Department>()
            //                                 .HasOne(D => D.Manager)
            //                                 .WithOne(E => E.Department)
            //                                 .HasForeignKey<Department>(D => D.EmpId);


            //modelBuilder.Entity<Department>()
            //                                 .HasOne(D => D.Id)
            //                                 .WithOne(D => D.WorkFor)
            //                                 .HasForeignKey(D => D.WorkForId);

            //modelBuilder.Entity<StudCourse>().HasKey(SC => new { SC.CourseId, SC.StudentId });



            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ItI_GP04; Trusted_Connection=True; TrustServerCertificate=True;");
        }
        public DbSet<Entities.Student> Students { get; set; }
        public DbSet<Entities.Course> Courses { get; set; }
        public DbSet<Entities.StudCourse> StudCourses { get; set; }
        public DbSet<Entities.Topic> Topics { get; set; }
        public DbSet<Entities.Department> Departments { get; set; } 
        








    }
}
