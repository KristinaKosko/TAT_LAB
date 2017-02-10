using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    [TestClass()]
    public class JournalMSTests
    {
        static List<string> names { get { return DataGetterFromExcel.GetNamesOfJournals(Convert.ToInt16(TestData.BatchNumber)); } }

        [TestMethod()]
        [DeploymentItem("TestFramework\\Responsive-Batch-4.xlsx")]
        [DataSource("names")]
        public void JournalTests(string journal)
        {
            Steps.OpenJournal(journal);
            List<NavigationItem> naviItems = DataGetterFromExcel.GetNavigationItems(Convert.ToInt16(TestData.BatchNumber), journal);
            foreach (var naviItem in naviItems)
            {
                Assert.IsTrue(Steps.CheckItems(naviItem));
            }
        }

        [ClassCleanup]
        public void EndTest()
        {
            Steps.End();
        }
        public void GetNavigationItemsTest()
        {
            Assert.Fail();
        }
    }
}