using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment2
{
    class Account
    {
        private int accountNo = 10000;
        private string accountName;
        private DateTime dob;
        private string address;
        private double balance;
        private int transactions;

        public Account(string accountName, DateTime dob, string address,double balance)
        {
            this.accountNo = ++accountNo;
            this.accountName = accountName;
            this.dob = dob;
            this.address = address;
            this.balance = balance;
            this.transactions = 0;
        }

        public void showDetails()
        {
            Console.WriteLine("Account No: " + this.accountNo);
            Console.WriteLine("Account Name: " + this.accountName);
            Console.WriteLine("Date of Birth: " + this.dob.ToShortDateString());
            Console.WriteLine("Address: " + this.address);
            Console.WriteLine("Starting Balance: " + this.balance);
            Console.WriteLine("Transactions: " + this.transactions);
        }
    }
}
