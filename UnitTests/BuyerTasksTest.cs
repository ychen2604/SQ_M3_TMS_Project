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
            BuyerTasks BuyerTest = new BuyerTasks();
            Assert.AreEqual(true, BuyerTest.ReviewCustomer(""));
        }

        [TestMethod]
        public void IsReviewCustomersFalse()
        {
            BuyerTasks BuyerTest = new BuyerTasks();
            Assert.AreEqual(false, BuyerTest.ReviewCustomer(""));
        }

        [TestMethod]
        public void newOrderTrue()
        {
            BuyerTasks BuyerTest = new BuyerTasks();
            Assert.AreEqual(true, BuyerTest.newOrder(""));
        }

        [TestMethod]
        public void newOrderFalse()
        {
            BuyerTasks BuyerTest = new BuyerTasks();
            Assert.AreEqual(false, BuyerTest.newOrder(""));
        }

        [TestMethod]
        public void isCityTrue()
        {
            BuyerTasks BuyerTest = new BuyerTasks();
            Assert.AreEqual(true, BuyerTest.city(""));
        }

        [TestMethod]
        public void IsCityFalse()
        {
            BuyerTasks BuyerTest = new BuyerTasks();
            Assert.AreEqual(false, BuyerTest.city(""));
        }
        
        
        [TestMethod]
        public void isInvoiceGenerationTrue()
        {
            BuyerTasks BuyerTest = new BuyerTasks();
            Assert.AreEqual(true, BuyerTest.invoiceGeneration(""));
        }

        [TestMethod]
        public void isInvoiceGenerationFalse()
        {
            BuyerTasks BuyerTest = new BuyerTasks();
            Assert.AreEqual(false, BuyerTest.invoiceGeneration(""));
        }
    }
}
