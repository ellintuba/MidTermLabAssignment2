using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment2
{
    class Program
    {
        static List<Savings> SavingsAccounts = new List<Savings>();
        static List<Checking> CheckingAccounts = new List<Checking>();
        static void Main(string[] args)
        {
            dashboard();
        }

        static void dashboard()
        {
            string inputCommand;
            while (true)
            {
                Console.WriteLine("Enter the command for :");
                Console.WriteLine("Open a Bank account - open");
                Console.WriteLine("Perform transactions for an account - account");
                Console.WriteLine("Exit the application - quit");
                inputCommand = Console.ReadLine();
                switch (inputCommand)
                {
                    case "open":
                        openAccountMenu();
                        break;
                    case "account":
                        performAccountMenu();
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Command. Please Enter open or account or quit as command");
                        break;
                }
            }
        }
        static void openAccountMenu()
        {
            while (true)
            {
                Console.WriteLine("Enter the command for :");
                Console.WriteLine("Open a savings account - savings");
                Console.WriteLine("Open a checking account - checking");
                Console.WriteLine("Exit the application - quit");
                string opentAccountCommand = Console.ReadLine();
                switch (opentAccountCommand)
                {
                    case "savings":
                        openAccount("savings");
                        break;
                    case "checking":
                        openAccount("checking");
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Command. Please Enter savings or checking or quit as command");
                        break;
                }
            }
        }

        static void openAccount(string type)
        {
            Console.WriteLine("Enter Details for Open New Account:");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Date of Birth: (e.g. 10/22/1987) ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Starting Balance: ");
            double balance =Double.Parse(Console.ReadLine());
            if (type.Equals("savings"))
            {
                Savings sacc = new Savings(name, dob, address,balance,type);
                SavingsAccounts.Add(sacc);
            }
            else
            {
                Checking cacc = new Checking(name, dob, address, balance,type);
                CheckingAccounts.Add(cacc);
            }
            dashboard();
        }
        static void performAccountMenu()
        {
            string inputCommand;
            while (true)
            {
                Console.WriteLine("Enter the command for :");
                Console.WriteLine("Make a deposit - deposit");
                Console.WriteLine("Make a withdrawal - withdraw");
                Console.WriteLine("Make a transfer - transfer");
                Console.WriteLine("Show the number transactions and balance - show");
                Console.WriteLine("Exit the application - quit");
                inputCommand = Console.ReadLine();
                switch (inputCommand)
                {
                    case "deposit":
                        Console.WriteLine("Enter account no for deposit:");
                        int accountNo=Int32.Parse(Console.ReadLine());
                        break;
                    case "withdraw": 
                        break;
                    case "quit":
                    Environment.Exit(0);
                    break;
                    default:
                    Console.WriteLine("Invalid Command. Please Enter valid command");
                    break;
                }
            }
        }
    }
}
