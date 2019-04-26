using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopLibrary
{
    public class Receipt
    {
        public double Total { get; set; }
        public int PointsEarned { get; set; }
        public DoubleLinkedList Items { get; set; }
        public int TransNo { get; set; }
        public int CustNo { get; set; }
        public int EmpNo { get; set; }

        private static int currentTransNo = 0;

        #region Constructors()
        public Receipt()
        {
            Total = 0;
            PointsEarned = 0;
            Items = new DoubleLinkedList();
            TransNo = currentTransNo++;
            CustNo = 0;
            EmpNo = 0;

        }

        public Receipt(int customerNo, int employeeNo)
        {
            Total = 0;
            PointsEarned = 0;
            Items = new DoubleLinkedList();
            TransNo = currentTransNo++;
            CustNo = customerNo;
            EmpNo = employeeNo;
        }
        #endregion

        public void ScanItem(int id,string name, double price, int quantity)
        {
            ItemReceiptInstance i = new ItemReceiptInstance(id,name, price,quantity);

            Items.Add(i);

            Total += price * quantity;
            
        }

        public void DeleteByIndex(int item)
        {
            ItemReceiptInstance v = Items.RemoveNthItem(item);

            if (v != null)
            {
                Total -= v.Price * v.Quantity;
            }
        }

        public void DeleteLastScannedItem()
        {
            ItemReceiptInstance v = Items.RemoveLastAdded();

            if (v != null)
            {
                Total -= v.Price * v.Quantity;
            }
        }

        public void DeleteAll()
        {
            Items.header = null;
            Items.tail = null;
            Total = 0;
        }

    }
}