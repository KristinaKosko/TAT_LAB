using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Tests
{
    [TestClass()]
    public class ExcelParserMSTests
    {
        static List<string> names { get { return ExcelParser.GetNamesOfJournals(); } }

        [TestMethod()]
        [DeploymentItem("TestFramework\\Responsive-Batch-4.xlsx")]
        [DataSource("names")]
        public void JournalTests(string journal)
        {
            Steps.OpenJournal(journal);
            List<NavigationItem> naviItems = ExcelParser.GetNavigationItems(journal);
            ExcelParser.ExcelKill();
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