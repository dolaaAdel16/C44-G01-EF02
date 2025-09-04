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

            #region CRUD Operations (Create)
            //var employee = new Employee()
            //{
            //    Name = "Mohammed Ali",
            //    Salary = 13000 , 
            //    Address = "Cairo" , 
            //    Age = 22 
            //};


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


            #region CRUD Operations (Retrive)
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 4);

            ////var Result = context.Employees.Select(E => E.Name);

            //Console.WriteLine(context.Entry(Result).State);

            //Result.Name = "Ali";  

            //Console.WriteLine(context.Entry(Result).State);

            //foreach (var item in Result)
            //{ 
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.Id);

            //}

            //Console.WriteLine(Result?.Name);
            //Console.WriteLine(Result?.Id); 
            #endregion


            #region CRUD Operations (Update)
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 4 );

            //Console.WriteLine(context.Entry(Result).State); 

            //Result.Name = "Omar Ali";
            ////Console.WriteLine(context.Entry(Result).State);

            ////context.Update(Result);
            //Console.WriteLine(context.Entry(Result).State);


            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State); 
            #endregion


            #region CRUD Operations (Delete)
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 3);

            //Console.WriteLine(context.Entry(Result).State);

            //context.Employees.Remove(Result);
            //Console.WriteLine(context.Entry(Result).State);

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State); 
            #endregion


            #region One-One Relationship
            //Department department = new Department();
            //department.Manager. 
            #endregion


            #region One-Many Relationship

            //Employee employee = new Employee();
            //Department department = new Department();

            //employee.WorkFor

            #endregion


        }
    }
}
