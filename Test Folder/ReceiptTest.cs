using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShopLibrary;


namespace MyShopTest
{
    [TestClass]
    public class ReceiptTest
    {

        #region ScanItem() Test
        [TestMethod]
        public void ScanItemTest()
        {
            int id = 15;
            string name = "shoes";
            double price = 30.0;
            int quantity = 2;

            Receipt r = new Receipt();
            r.ScanItem(id,name,price,quantity);

            Assert.AreEqual(15, r.Items.header.value.ItemID);
            Assert.AreEqual("shoes", r.Items.header.value.Name);
            Assert.AreEqual(30.0, r.Items.header.value.Price);
            Assert.AreEqual(2, r.Items.header.value.Quantity);

            Assert.AreEqual(60,r.Total);
        }

        [TestMethod]
        public void ScanItemTestMultiple()
        {
            Receipt r = new Receipt();
            r.ScanItem(0, "s", 10, 2);
            r.ScanItem(1, "t", 20, 5);

            //Adding items with prices 10*2 + 20*5
            //total should be 120
            Assert.AreEqual(120, r.Total);
        }
        #endregion

        #region DeleteNthItems() Test
        [TestMethod]
        public void DeleteNthItemTest()
        {
            Receipt r = new Receipt();
            TestSetup(r);

            r.DeleteByIndex(0);

            Assert.AreEqual(2240, r.Total);
        }

        [TestMethod]
        public void DeleteNthItemTestOutOfRange()
        {
            Receipt r = new Receipt();
            TestSetup(r);

            r.DeleteByIndex(4);

            Assert.AreEqual(2300, r.Total);
        }
        #endregion

        #region RemoveLastScannedItem() Test
        [TestMethod]
        public void RemoveLastScannedItemTest()
        {
            Receipt r = new Receipt();
            TestSetup(r);

            r.DeleteLastScannedItem();

            Assert.AreEqual(300,r.Total);

        }

        [TestMethod]
        public void RemoveLastScannedItemTestMultiple()
        {
            Receipt r = new Receipt();
            TestSetup(r);

            r.DeleteLastScannedItem();
            r.DeleteLastScannedItem();
            r.DeleteLastScannedItem();

            Assert.AreEqual(0, r.Total);

        }

        [TestMethod]
        public void RemoveLastScannedItemTestOver()
        {
            Receipt r = new Receipt();

            r.DeleteLastScannedItem();

            Assert.AreEqual(0, r.Total);

        }
        #endregion

        [TestMethod]
        public void DeleteAllTest()
        {
            Receipt r = new Receipt();
            TestSetup(r);

            r.DeleteAll();

            Assert.AreEqual(null,r.Items.header);
            Assert.AreEqual(null, r.Items.tail);
            Assert.AreEqual(0, r.Total);
        }

        public void TestSetup(Receipt r)
        {
            r.ScanItem(15, "shoes", 30.0, 2);
            r.ScanItem(5, "videogames", 60.0, 4);
            r.ScanItem(666,"gfold",2000.0,1);
        }
    }
}
