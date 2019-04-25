using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShopLibrary;

namespace MyShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;

            bool continueTransactions = true;
            do
            {
                Console.Write("Enter Employee Number: ");
                string EmpNo = Console.ReadLine();
                Console.Write("Enter Employee Name: ");
                string EmpName = Console.ReadLine();
                Console.Write("Enter Employee Level: ");
                string EmpLevel = Console.ReadLine();

                //Console.WriteLine(EmpNo + " " + EmpName + " " + EmpLevel);
                Console.WriteLine();
                
                bool continueItems = true;
                do
                {
                    Console.Write("Enter Customer Name: ");
                    string CustName = Console.ReadLine();
                    Console.Write("Enter Customer Phone Number: ");
                    string CustPhone = Console.ReadLine();
                    Console.Write("Enter Customer Email: ");
                    string CustEmail = Console.ReadLine();
                    
                    //Console.WriteLine(CustName + " " + CustPhone + " " + CustEmail);
                    Console.WriteLine();

                    Console.Write("Enter Item Number: ");
                    string itemNum = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    string itemQuant = Console.ReadLine();

                    Console.WriteLine("Adding " + itemQuant + " " + itemNum + "(s) to order.");
                    Console.WriteLine();

                    Console.Write("Continue adding items? (Y/N)");
                    do
                    {
                        input = Console.ReadKey(true).KeyChar;
                    } while (!(input == 'y' || input == 'n' || input == 'Y' || input == 'N'));
                    Console.WriteLine(" " + input);

                    if (input == 'n')
                    {
                        continueItems = false;
                    }
                } while (continueItems);
                //calculate transaction toal;

                double total = 0;
                Console.WriteLine("Transaction total: $" + total);

                Console.WriteLine("Continue with another transaction: (Y/N)");
                do
                {
                    input = Console.ReadKey(true).KeyChar;
                } while (!(input == 'y' || input == 'n' || input == 'Y' || input == 'N'));
                Console.WriteLine(" " + input);
                if(input == 'n')
                {
                    continueTransactions = false;
                }
            } while (continueTransactions);
        }
    }
}
