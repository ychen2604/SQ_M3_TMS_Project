using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SQ_TMS_Project;

namespace UnitTests
{
    [TestClass]
    public class AdminTaskTests
    {
        [TestMethod]
        public void IsBackUpTrue()
        {
            AdminTasks adm = new AdminTasks();
            Assert.AreEqual(true, adm.BackUp(0));
        }

        [TestMethod]
        public void IsBackUpFalse()
        {
            AdminTasks adm = new AdminTasks();
            Assert.AreEqual(false, adm.BackUp(1));
        }

        [TestMethod]
        public void ReviewLogFilesTrue()
        {
            AdminTasks adm = new AdminTasks();
            Assert.AreEqual(true, adm.ReviewLogFiles(""));
        }

        [TestMethod]
        public void ReviewLogFilesFalse()
        {
            AdminTasks adm = new AdminTasks();
            Assert.AreEqual(false, adm.ReviewLogFiles(""));
        }

        [TestMethod]
        public void IsAlterTableTrue()
        {
            AdminTasks adm = new AdminTasks();
            Assert.AreEqual(true, adm.AlterTable("", ""));
        }

        [TestMethod]
        public void IsAlterTableFalse()
        {
            AdminTasks adm = new AdminTasks();
            Assert.AreEqual(false, adm.AlterTable("", ""));
        }
    }
}
