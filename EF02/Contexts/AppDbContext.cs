using EF02.Configurations;
using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Contexts
{
    internal class AppDbContext : DbContext
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

            modelBuilder.ApplyConfiguration(new EmpolyeeConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly())


            //modelBuilder.Entity<Employee>().HasOne(E => E.Department)
            //                               .WithOne(D => D.Manager)
            //                               .HasForeignKey<Department>(D => D.EmpId);

            //modelBuilder.Entity<Department>()
            //                                 .HasOne(D => D.Manager)
            //                                 .WithOne(E => E.Department)
            //                                 .HasForeignKey<Department>(D => D.EmpId);


            modelBuilder.Entity<Department>()
                                             .HasMany(D => D.Employees)
                                             .WithOne(E => E.WorkFor)
                                             .HasForeignKey(E => E.WorkForId);

            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.CourseId, SC.StudentId });



            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server = .;  Database = AppGP04;  Trusted_Connection = True;  TrustServerCertificate = True; ");

            optionsBuilder.UseSqlServer("Server = .;  Database = AppGP04;  Trusted_Connection = True;  TrustServerCertificate = True ");

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
    }

}