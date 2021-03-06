using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment2
{
    class Savings:Account
    {
        public Savings(string name, DateTime dob, string address, double balance, string type)
            : base(name, dob, address, balance, type)
        {
            Console.WriteLine("Savings Account Created");
        }
    }
}
