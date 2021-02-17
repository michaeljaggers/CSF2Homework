using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //Fields

        //Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        //Constructors
        public Book() { }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = Author;
            NumberOfPages = numberOfPages;
        }

        //Methods
        public override string ToString()
        {
            return Title;
        }//end ToString
    }//end class
}//end namespace
