﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCommand;
            while (true)
            {
                Console.WriteLine("Enter the command for :");
                Console.WriteLine("Open a Bank account");
                Console.WriteLine("Perform transactions for an account");
                Console.WriteLine("Exit the application");
                inputCommand = Console.ReadLine();
                switch (inputCommand)
                {
                    case "open":
                        Console.WriteLine(inputCommand);
                        break;
                    case "account":
                        Console.WriteLine(inputCommand);
                        break;
                    case "quit":
                        return;
                    default:
                        Console.WriteLine("Invalid Command. Please Enter open or account or quit as command");
                        break;
                }
            }
        }
    }
}
