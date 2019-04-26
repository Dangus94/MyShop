using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopLibrary
{
    public class ItemReceiptInstance
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int ItemID { get; set; }

        #region Constructors
        public ItemReceiptInstance()
        {
            Name = "";
            Price = 0.0d;
            Quantity = 0;
        }

        public ItemReceiptInstance(int id, string n, double p, int q)
        {
            ItemID = id;
            Name = n;
            Price = p;
            Quantity = q;
        }

        public ItemReceiptInstance(string n, double p, int q)
        {
            Name = n;
            Price = p;
            Quantity = q;
        }

        public ItemReceiptInstance(int id, string n, double p)
        {
            ItemID = id;
            Name = n;
            Price = p;
            Quantity = 0;
        }

        public ItemReceiptInstance(string n, double p)
        {
            Name = n;
            Price = p;
            Quantity = 0;
        }

        public ItemReceiptInstance(int id, string n)
        {
            ItemID = id;
            Name = n;
            Price = 0.0d;
            Quantity = 0;
        }

        public ItemReceiptInstance(string n)
        {
            Name = n;
            Price = 0.0d;
            Quantity = 0;
        }
        #endregion

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(Name + " " + Quantity + " " + Price + "\n");

            return s.ToString();
        }
    }
}