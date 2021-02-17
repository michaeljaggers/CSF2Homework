﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TestProgram
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

            ContactInfo i1 = new ContactInfo();
            i1.StreetAddress = "1234 MAIN ST";
            i1.City = "KANSAS CITY";
            i1.State = "MISSOURI";
            i1.Zip = "64154";
            i1.Phone = "816-555-8654";
            i1.Email = "jsmith@gmail.com";

            ContactInfo i2 = new ContactInfo("2525 S WALES RD", "LIBERTY", "MISSOURI", "64068", "816-555-2868", "mhall@gmail.com");

            Console.WriteLine(i1);
            Console.WriteLine(i2);

            Console.WriteLine("\n- Customer Objects -\n");

            Customer c1 = new Customer();
            c1.FirstName = "John";
            c1.LastName = "Smith";
            c1.CustomerId = "010203";
            c1.ContactInformation = i1;

            Customer c2 = new Customer("040506", "Mark", "Hall", i2);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("\n- CreditCardAccount Objects -\n");

            CreditCardAccount a1 = new CreditCardAccount();
            a1.AccountNumber = 1000098765;
            a1.Balance = 50000.32M;
            a1.IsPastDue = false;
            a1.CustomerInfo = c1;
            a1.AnnualInterestRate = 23.4M;

            CreditCardAccount a2 = new CreditCardAccount(1000098766, c2, 25000.50M, true, 17.6M);

            Console.WriteLine(a1);
            Console.WriteLine(a2);

            Console.WriteLine("\n- Book Objects -\n");

            Book b1 = new Book();
            b1.Title = "The Complete Idiot's Guide to the Internet";
            b1.Author = "Peter Kent";
            b1.NumberOfPages = 394;

            Book b2 = new Book("Facebook For Dummies", "Carolyn Abram", 432);
            Book b3 = new Book("Think and Grow Rich", "Napoleon Hill", 320);
            Book b4 = new Book("The Richest Man in Babylon", "George S. Clason", 144);

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);

            Console.WriteLine("\n- Library Objects -\n");

            List<Book> books1 = new List<Book>();
            books1.Add(b1);
            books1.Add(b2);

            List<Book> books2 = new List<Book>() { b3, b4 };

            Library lib1 = new Library();
            lib1.LibraryName = "Mid-Continent Public Library";
            lib1.StreetAddress = "8700 N OAK TRFY";
            lib1.City = "KANSAS CITY";
            lib1.State = "MO";
            lib1.Zip = "64155";
            lib1.Books = books1;

            Library lib2 = new Library("New York Public Library", "203 W 115TH ST", "NEW YORK", "NY", "10026", books2);

            Console.WriteLine(lib1);
            Console.WriteLine(lib2);

        }//end Main
    }//end class
}//end namespace
