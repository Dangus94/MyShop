using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShopLibrary;

namespace MyShopTest
{
    [TestClass]
    public class DoubleLinkedListTest
    {
        #region Add() Test
        [TestMethod]
        public void AddTest()
        {
            ItemReceiptInstance IRI = new ItemReceiptInstance();
            IRI.Name = "Apples";
            IRI.Price = 1.50;
            IRI.Quantity = 3;

            DoubleLinkedList dll = new DoubleLinkedList();
            dll.Add(IRI);

            Assert.AreEqual("Apples", dll.header.value.Name);
            Assert.AreEqual(1.50, dll.header.value.Price);
            Assert.AreEqual(3, dll.header.value.Quantity);
            Assert.AreEqual("Apples", dll.tail.value.Name);
            Assert.AreEqual(1.50, dll.tail.value.Price);
            Assert.AreEqual(3, dll.tail.value.Quantity);
        }

        [TestMethod]
        public void AddMultipleTest()
        {
            #region ItemReceiptInstance Instantiation
            ItemReceiptInstance IRI = new ItemReceiptInstance();
            IRI.Name = "Apples";
            IRI.Price = 1.50;
            IRI.Quantity = 3;

            ItemReceiptInstance IRI2 = new ItemReceiptInstance();
            IRI2.Name = "Pears";
            IRI2.Price = 0.33;
            IRI2.Quantity = 7;
            #endregion

            #region Add to DLL
            DoubleLinkedList dll = new DoubleLinkedList();
            dll.Add(IRI);
            dll.Add(IRI2);
            #endregion

            #region Asserts
            Assert.AreEqual("Apples", dll.tail.value.Name);
            Assert.AreEqual(1.50, dll.tail.value.Price);
            Assert.AreEqual(3, dll.tail.value.Quantity);

            Assert.AreEqual("Pears", dll.header.value.Name);
            Assert.AreEqual(0.33, dll.header.value.Price);
            Assert.AreEqual(7, dll.header.value.Quantity);
            #endregion
        }
        #endregion

        #region PrintInReverse() Test
        [TestMethod]
        public void PrintInReverseTest()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            TestSetup(dll);

            string expected = "Apples 3 1.5\nPears 7 0.33\n";

            Assert.AreEqual(expected, dll.PrintInReverse());
        }

        [TestMethod]
        public void PrintInReverseEmptyTest()
        {
            DoubleLinkedList dll = new DoubleLinkedList();

            string expected = "";

            Assert.AreEqual(expected, dll.PrintInReverse());
        }
        #endregion

        #region RemoveLastAdded() Test
        [TestMethod]
        public void RemoveLastAddedTest()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            TestSetup(dll);

            dll.RemoveLastAdded();

            Assert.AreEqual("Apples", dll.header.value.Name);
            Assert.AreEqual(1.50, dll.header.value.Price);
            Assert.AreEqual(3, dll.header.value.Quantity);
            Assert.AreEqual("Apples", dll.tail.value.Name);
            Assert.AreEqual(1.50, dll.tail.value.Price);
            Assert.AreEqual(3, dll.tail.value.Quantity);
        }

        [TestMethod]
        public void RemoveLastAddedAllTest()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            TestSetup(dll);

            dll.RemoveLastAdded();
            dll.RemoveLastAdded();

            Assert.AreEqual(null, dll.header);
            Assert.AreEqual(null, dll.tail);
        }

        [TestMethod]
        public void RemoveLastAddedOverTest()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            TestSetup(dll);

            dll.RemoveLastAdded();
            dll.RemoveLastAdded();
            dll.RemoveLastAdded();

            Assert.AreEqual(null, dll.header);
            Assert.AreEqual(null, dll.tail);
        }
        #endregion

        #region RemoveNthItem() Test
        [TestMethod]
        public void RemoveNthItemTest()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            TestSetup(dll);

            dll.RemoveNthItem(0);

            Assert.AreEqual("Pears", dll.header.value.Name, "Pears should be header");
            Assert.AreEqual(0.33, dll.header.value.Price);
            Assert.AreEqual(7, dll.header.value.Quantity);
            Assert.AreEqual("Pears", dll.tail.value.Name, "Pears should be tail");
            Assert.AreEqual(0.33, dll.tail.value.Price);
            Assert.AreEqual(7, dll.tail.value.Quantity);
        }

        [TestMethod]
        public void RemoveNthItemTestOther()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            TestSetup(dll);

            dll.RemoveNthItem(1);

            Assert.AreEqual("Apples", dll.header.value.Name, "Apples should be header");
            Assert.AreEqual(1.5, dll.header.value.Price);
            Assert.AreEqual(3, dll.header.value.Quantity);
            Assert.AreEqual("Apples", dll.tail.value.Name, "Apples should be tail");
            Assert.AreEqual(1.5, dll.tail.value.Price);
            Assert.AreEqual(3, dll.tail.value.Quantity);
        }

        [TestMethod]
        public void RemoveNthItemTestAll()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            TestSetup(dll);

            dll.RemoveNthItem(0);
            dll.RemoveNthItem(0);

            Assert.AreEqual(null, dll.header);
            Assert.AreEqual(null, dll.tail);
        }

        [TestMethod]
        public void RemoveNthItemTestOverEmpty()
        {
            DoubleLinkedList dll = new DoubleLinkedList();

            dll.RemoveNthItem(0);

            Assert.AreEqual(null, dll.header);
            Assert.AreEqual(null, dll.tail);
        }

        [TestMethod]
        public void RemoveNthItemTestOverNotEmpty()
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            TestSetup(dll);

            dll.RemoveNthItem(2);

            Assert.AreEqual("Pears", dll.header.value.Name, "Pears should be header");
            Assert.AreEqual(0.33, dll.header.value.Price);
            Assert.AreEqual(7, dll.header.value.Quantity);
            Assert.AreEqual("Apples", dll.tail.value.Name, "Apple should be tail");
            Assert.AreEqual(1.5, dll.tail.value.Price);
            Assert.AreEqual(3, dll.tail.value.Quantity);
        }
        #endregion

        public void TestSetup(DoubleLinkedList dll)
        {
            #region ItemReceiptInstance Instantiation
            ItemReceiptInstance IRI = new ItemReceiptInstance();
            IRI.Name = "Apples";
            IRI.Price = 1.50;
            IRI.Quantity = 3;

            ItemReceiptInstance IRI2 = new ItemReceiptInstance();
            IRI2.Name = "Pears";
            IRI2.Price = 0.33;
            IRI2.Quantity = 7;
            #endregion

            dll.Add(IRI);
            dll.Add(IRI2);
        }
    }
}
