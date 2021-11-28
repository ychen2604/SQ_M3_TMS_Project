using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SQ_TMS_Project;

namespace UnitTests
{
    [TestClass]
    public class PlannerTasksTest
    {
        [TestMethod]
        public void IsReceiversOrderTrue()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(true, planTest.ReceiversOrder(0,0));
        }

        [TestMethod]
        public void IsReceiversOrderFalse()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(false, planTest.ReceiversOrder(0, 0));
        }

        [TestMethod]
        public void TestSelectCarriers()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(1, planTest.SelectCarriers(0, 50));
        }

        [TestMethod]
        public void TestWhenSplitToMultipleTrips()
        {
            int[] carrierArray = new int[50];
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(carrierArray, planTest.WhenSplitToMultipleTrips(0,50));
        }

        [TestMethod]
        public void TestOneDayIncrements()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(1, planTest.OneDayIncrements(0));
        }

        [TestMethod]
        public void IsConfirmOrderCompletedTrue()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(true, planTest.ConfirmOrderCompleted(0));
        }

        [TestMethod]
        public void IsConfirmOrderCompletedFalse()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(false, planTest.PrintSummary(0));
        }


        [TestMethod]
        public void TestPrintSummary()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(1, planTest.PrintSummary(1));
        }
    }
}
