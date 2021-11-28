using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SQ_TMS_Project;

namespace UnitTests
{
    [TestClass]
    public class PlannerTasksTest
    {
        [TestMethod]
        public void IsReviewCustomersTrue()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(true, planTest.ReceiversOrder(0,0));
        }

        [TestMethod]
        public void IsReviewCustomersFalse()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(false, planTest.SelectCarriers(0,50));
        }

        [TestMethod]
        public void newOrderTrue()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(true, planTest.WhenSplitToMultipleTrips(0,50));
        }

        [TestMethod]
        public void newOrderFalse()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(false, planTest.OneDayIncrements(0));
        }

        [TestMethod]
        public void isCityTrue()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(true, planTest.ConfirmOrderCompleted(0));
        }

        [TestMethod]
        public void IsCityFalse()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(false, planTest.PrintSummary(0));
        }


        [TestMethod]
        public void isInvoiceGenerationTrue()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(true, planTest.PrintSummary(1));
        }

        [TestMethod]
        public void isInvoiceGenerationFalse()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(false, planTest.PrintSummary(2));
        }
    }
}
