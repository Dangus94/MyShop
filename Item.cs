using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopLibrary
{
    public class Item
    {
        public double  Price { set; get; }
        public string Name { set; get; }

        public int Quantity { set; get; }
        public double Discount { set; get; }

        public Item()            //Default constructor
        {
            Price = 0.0d;
            Name = "";
            Quantity = 0;
            Discount = 0.0d;
        }

        public Item(double itemPrice, string itemName, int itemQuantity, double itemDiscount)            //Non-Default constructor
        {
            Price = itemPrice;
            Name = itemName;
            Quantity = itemQuantity;
            Discount = itemDiscount;
        }

        
        
        public int AddInventory(int items)      //Method to add inventory to the existing quantity 
        {
            if (items <= 0)
            {
                Console.WriteLine("Inventory additions need to be <=1");
                return 0;
            }
            else
            {
                Quantity += items;
                return Quantity;
            }
        } // end AddInventory()
    }
}
