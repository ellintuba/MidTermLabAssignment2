using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment2
{
    class Checking:Account
    {
        public Checking(string name, DateTime dob, string address, double balance, string type)
            : base(name, dob, address, balance, type)
        {
            Console.WriteLine("Checking Account Created");
        }
    }
}