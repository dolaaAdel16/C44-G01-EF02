using EF02.Contexts;
using EF02.Entities;
using Microsoft.EntityFrameworkCore;


namespace EF02
{
    internal class Program
    {
        static void Main()
        {
            //Important Revesion 

            #region Prepare for CRUD Operations 
            //AppDbContext context = new AppDbContext();

            //try 
            //{
            //    //code
            //}
            //finally
            //{
            //    context.Dispose();
            //}

            //using (AppDbContext context = new AppDbContext())
            //{ 
            //   //CRUD

            //}

            //using AppDbContext context = new AppDbContext(); 
            #endregion

            using AppDbContext context = new AppDbContext();

            var employee = new Employee()
            {
                Name = "Mohammed Ali",
                Salary = 13000 , 
                Address = "Cairo" , 
                Age = 22 
            };

            #region CRUD Operations (Retrive)
            //Console.WriteLine(context.Entry(employee).State);

            //employee.Name = "Mohamed";  

            //Console.WriteLine(context.Entry(employee).State);
            ////context.Add(employee);
            //context.Employees.Add(employee);

            //Console.WriteLine(context.Entry(employee).State);

            //var Result = context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State);

            //employee.Name = "Omar";

            //Console.WriteLine(context.Entry(employee).State);

            //Console.WriteLine(Result);   

            //context.Employees.Add(employee);
            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State);   
            //context.Entry(employee).State = EntityState.Added;
            //Console.WriteLine(context.Entry(employee).State);

            //context.SaveChanges();  

            #endregion 





        }
    }
}
