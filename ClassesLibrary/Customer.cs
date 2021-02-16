using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //Fields

        //Properties
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        //Constructors
        public Customer() { }

        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Customer Name: {0}, {1}\n" +
                "Customer ID: {2}\n" +
                "{3}\n",
                LastName, FirstName, CustomerId, ContactInformation);
        }//end ToString
    }//end class
}//end namespace
