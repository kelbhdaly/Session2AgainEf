using Microsoft.EntityFrameworkCore;
using Session2Again.DbContexts;
using Session2Again.Models;

namespace Session2Again
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Session02Again session2Again = new Session02Again();

            #region Add-New Record In Table Employee -Insert
            //session2Again.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //    Employee employee01 = new Employee()
            //    {
            //        Name = "Khaled",
            //        Age = 20,
            //        PhoneNumber = "1280051",
            //        Email ="asd@",
            //        Salary =10000,
            //        Password ="2580528",
            //        Test=999999,

            //    };

            //    Console.WriteLine(session2Again.Entry<Employee>(employee01).State); //Detached

            //    session2Again.Add<Employee>(employee01); //First
            //    session2Again.Set<Employee>().Add(employee01);
            //    session2Again.Employees.Add(employee01);
            //    Console.WriteLine(session2Again.Entry<Employee>(employee01).State); //Added

            //    session2Again.SaveChanges();
            //    Console.WriteLine(session2Again.Entry<Employee>(employee01).State); //Added 
            #endregion

            #region To Retrive Data From Table In Database - Select

            //session2Again.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //var emp = session2Again.Employees.Where(E => E.Id == 1).FirstOrDefault();
            //emp = session2Again.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 1);
            //emp = session2Again.Employees.SingleOrDefault(E => E.Id == 1);

            //if (emp != null) 
            //Console.WriteLine(session2Again.Entry<Employee>(emp).State);

            //emp.Name = "Malak";
            //session2Again.SaveChanges();
            #endregion

            #region Update Table 

            //session2Again.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //var emp = session2Again.Employees.FirstOrDefault(E => E.Id ==1);
            //if (emp != null)
            //{
            //    emp.Name = "May";
            //    Console.WriteLine(session2Again.Entry<Employee>(emp).State);
            //    Console.WriteLine("After Changed");   
            //    session2Again.SaveChanges();
            //    Console.WriteLine(session2Again.Entry<Employee>(emp).State);
            //}

            #endregion

            #region Remove Data From Table in DataBase - Delete

            //var emp = session2Again.Employees.FirstOrDefault(E=>E.Id==1);
            //if(emp != null)
            //{
            //    Console.WriteLine(session2Again.Entry(emp).State);
            //    session2Again.Employees.Remove(emp);
            //    session2Again.Remove(emp);
            //    session2Again.Entry(emp).State = EntityState.Deleted;
            //    session2Again.Set<Employee>().Remove(emp);
            //    Console.WriteLine(session2Again.Entry(emp).State);

            //}

            #endregion

            #region Test
            //Employee employee = new Employee()
            //{

            //    PhoneNumber = "125050",
            //    Name = "Test",
            //    Email = "akq@505",
            //    Age = 25,
            //    Password = "12Password",
            //    Salary = 1000000
            //};

            //session2Again.Employees.Add(employee);
            //session2Again.Add(employee);
            //session2Again.Set<Employee>().Add(employee);
            //session2Again.Entry(employee).State = EntityState.Added;
            //session2Again.SaveChanges();

            //var emp = session2Again.Employees.FirstOrDefault(E => E.Id == 3);
            //if (emp != null)
            //{
            //    session2Again.Employees.Remove(emp);
            //    session2Again.Entry(emp).State = EntityState.Deleted;
            //    session2Again.Remove(emp);
            //    session2Again.Set<Employee>().Remove(emp);
            //    session2Again.SaveChanges();

            //}



            //var emp = session2Again.Employees.FirstOrDefault(E => E.Id == 5);
            //if (emp != null)
            //{
            //    emp.Name = "Ali";
            //    session2Again.SaveChanges();
            //}


            //var emp = session2Again.Employees.Single(E =>E.Id ==2);
            //Console.WriteLine(emp.Name);

            //session2Again.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.
            #endregion

       
        }
    }
}
