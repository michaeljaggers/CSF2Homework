using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CSF2 Homework";

            Console.WriteLine("\n- Student Objects -\n");

            Student s1 = new Student();
            s1.FirstName = "John";
            s1.LastName = "Smith";
            s1.Id = "s0001";
            s1.Gpa = 3.26F;

            Student s2 = new Student("Mark", "Hall", "s0002", 4.0F);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("\n- Vehicle Objects -\n");

            Vehicle v1 = new Vehicle();
            v1.Year = 2022;
            v1.Make = "Chevrolet";
            v1.Model = "Camaro";
            v1.Weight = 4120F;

            Vehicle v2 = new Vehicle("Ford", "Mustang", 2021, 3532F);

            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Console.WriteLine("\n- Login Objects -\n");

            Login l1 = new Login();
            l1.Username = "jsmith";
            l1.Password = "Password";

            Login l2 = new Login("mhall", "12345");

            Console.WriteLine(l1);
            Console.WriteLine(l2);

            Console.WriteLine("\n- ContactInfo Objects -\n");

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "1234 MAIN ST";
            c1.City = "KANSAS CITY";
            c1.State = "MISSOURI";
            c1.Zip = "64154";
            c1.Phone = "816-555-8654";
            c1.Email = "jsmith@gmail.com";

            ContactInfo c2 = new ContactInfo("2525 S WALES RD", "LIBERTY", "MISSOURI", "64068", "816-555-2868", "mhall@gmail.com");

            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }//end Main
    }//end class
}//end namespace
