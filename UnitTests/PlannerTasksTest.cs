using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SQ_TMS_Project;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class PlannerTasksTest
    {
        [TestMethod]
        public void ReceiversOrder()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(true, planTest.ReceiversOrder(0,0));
        }

        [TestMethod]
        public void CanSelectCarrier()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(14, planTest.SelectCarriers(0,50));
        }

        [TestMethod]
        public void CanSelectMultipleCarrier()
        {
            List<int> carrierArray = new List<int>();
            carrierArray.Add(1);
            carrierArray.Add(2);
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(carrierArray, planTest.WhenSplitToMultipleTrips(0,50));
        }

        [TestMethod]
        public void CanIncremeOneDay()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(1, planTest.OneDayIncrements(0));
        }

        [TestMethod]
        public void isConfirmOrderCompleted()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(true, planTest.ConfirmOrderCompleted(0));
        }

        [TestMethod]
        public void CanPrintSummaryA()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(0, planTest.PrintSummary(0));
        }


        [TestMethod]
        public void CanPrintSummaryB()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(1, planTest.PrintSummary(1));
        }

        [TestMethod]
        public void CanPrintSummaryC()
        {
            PlannerTasks planTest = new PlannerTasks();
            Assert.AreEqual(2, planTest.PrintSummary(2));
        }
    }
}
