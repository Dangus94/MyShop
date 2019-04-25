using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopLibrary
{
    class Receipt
    {
        public double Total { get; set; }
        public LinkedList<object> Items { get; set; }
        public int Points { get; set; }
        public Dictionary<int, double> ItemDetails { get; set; }

        public LinkedList<object> scanItem(int itemNum)
        {
            object item = ItemDetails[itemNum];
            Items.AddLast(item);
            return Items;
        }

        public double totalTransaction(LinkedList<object> scannedItems)
        {
            double subtotal = 0;
            double tax = 1.07;
            double total = 0;

            foreach(double price in scannedItems)
            {
                subtotal += price;
            }

            total = subtotal * tax;

            return total;
        }

        public int printReceipt(LinkedList<object> finalTransaction, double total, int rewards)
        {
            foreach(object o in finalTransaction)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Rewards: " + rewards);
            Console.WriteLine("");
            Console.WriteLine("Thank you for your purchase!");

            return 0;
        }
    }
}
