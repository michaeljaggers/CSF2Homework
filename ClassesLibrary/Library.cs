using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //Fields

        //Properties
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //Constructors
        public Library() { }

        public Library(string libraryName, string streetAddress, string city, string state, string zip, List<Book> books)
        {
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Books = books;
        }

        //Methods
        public override string ToString()
        {
            string booksAvailable = "";

            foreach (Book b in Books)
            {
                booksAvailable += b + "\n"; 
            }

            return string.Format("{0}\n" +
                "{1}\n" +
                "{2}, {3} {4}\n" +
                "Books Available:\n" +
                "{5}",
                LibraryName, StreetAddress, City, State, Zip, booksAvailable);
        }

    }//end class
}//end namespace
