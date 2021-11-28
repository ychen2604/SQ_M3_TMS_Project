using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SQ_TMS_Project;

namespace UnitTests
{
    [TestClass]
    public class BuyerTasksTest
    {
        [TestMethod]
        public void IsReviewCustomersTrue()                             
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(true, buyerTest.ReviewCustomers(""));
        }

        [TestMethod]
        public void IsReviewCustomersFalse()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(false, buyerTest.ReviewCustomers(""));
        }

        [TestMethod]
        public void NewOrderTrue()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(true, buyerTest.NewOrder("", ""));
        }

        [TestMethod]
        public void NewOrderFalse()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(false, buyerTest.NewOrder("", ""));
        }

        [TestMethod]
        public void IsCityTrue()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(true, buyerTest.City(""));
        }

        [TestMethod]
        public void IsCityFalse()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(false, buyerTest.City(""));
        }
        
        
        [TestMethod]
        public void IsInvoiceGenerationTrue()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(true, buyerTest.InvoiceGeneration(1));
        }

        [TestMethod]
        public void IsInvoiceGenerationFalse()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(false, buyerTest.InvoiceGeneration(1));
        }
    }
}
