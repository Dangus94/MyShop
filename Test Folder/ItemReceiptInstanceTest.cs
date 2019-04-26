using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShopLibrary;

namespace MyShopTest
{
    [TestClass]
    public class ItemReceiptInstanceTest
    {
        #region ToString() Test
        [TestMethod]
       public void ToStringTest()
        {
            ItemReceiptInstance IRI = new ItemReceiptInstance();
            IRI.Name = "Name";
            IRI.Price= 0.99;
            IRI.Quantity = 24;
       
            Assert.AreEqual("Name 24 0.99\n", IRI.ToString());
        }

        [TestMethod]
        public void ToStringTestEmpty()
        {
            ItemReceiptInstance IRI = new ItemReceiptInstance();
          
            Assert.AreEqual(" 0 0\n", IRI.ToString());
        }

        #endregion
    }
}
