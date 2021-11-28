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
            Assert.AreEqual(true, buyerTest.ReviewCustomer(""));
        }

        [TestMethod]
        public void IsReviewCustomersFalse()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(false, buyerTest.ReviewCustomer(""));
        }

        [TestMethod]
        public void newOrderTrue()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(true, buyerTest.newOrder(""));
        }

        [TestMethod]
        public void newOrderFalse()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(false, buyerTest.newOrder(""));
        }

        [TestMethod]
        public void isCityTrue()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(true, buyerTest.city(""));
        }

        [TestMethod]
        public void IsCityFalse()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(false, buyerTest.city(""));
        }
        
        
        [TestMethod]
        public void isInvoiceGenerationTrue()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(true, buyerTest.invoiceGeneration(""));
        }

        [TestMethod]
        public void isInvoiceGenerationFalse()
        {
            BuyerTasks buyerTest = new BuyerTasks();
            Assert.AreEqual(false, buyerTest.invoiceGeneration(""));
        }
    }
}
