using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //Fields

        //Properties
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //Constructors
        public CreditCardAccount() { }

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Account Number: {0}\n" +
                "Current Balance: {1:c}\t\tRate: {2}% APR\n" +
                "Payment Status: {3}\n" +
                "Customer: {4}\n",
                AccountNumber,
                Balance,
                AnnualInterestRate,
                IsPastDue ? "*Past Due" : "Current",
                CustomerInfo);
        }//end ToString
    }//end class
}//end namespace
