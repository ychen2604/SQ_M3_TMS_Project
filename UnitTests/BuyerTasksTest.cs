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
            BuyerTasks adm = new BuyerTasks();
            Assert.AreEqual(true, adm.ReviewCustomer(""));
        }

        [TestMethod]
        public void IsReviewCustomersFalse()
        {
            BuyerTasks adm = new BuyerTasks();
            Assert.AreEqual(false, adm.ReviewCustomer(""));
        }

        [TestMethod]
        public void newOrderTrue()
        {
            BuyerTasks adm = new BuyerTasks();
            Assert.AreEqual(true, adm.newOrder(""));
        }

        [TestMethod]
        public void newOrderFalse()
        {
            BuyerTasks adm = new BuyerTasks();
            Assert.AreEqual(false, adm.newOrder(""));
        }

        [TestMethod]
        public void isCityTrue()
        {
            BuyerTasks adm = new BuyerTasks();
            Assert.AreEqual(true, adm.city(""));
        }

        [TestMethod]
        public void IsCityFalse()
        {
            BuyerTasks adm = new BuyerTasks();
            Assert.AreEqual(false, adm.city(""));
        }
        
        
        [TestMethod]
        public void isInvoiceGenerationTrue()
        {
            BuyerTasks adm = new BuyerTasks();
            Assert.AreEqual(true, adm.invoiceGeneration(""));
        }

        [TestMethod]
        public void isInvoiceGenerationFalse()
        {
            BuyerTasks adm = new BuyerTasks();
            Assert.AreEqual(false, adm.invoiceGeneration(""));
        }
    }
}
