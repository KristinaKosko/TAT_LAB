using System;
using NUnit.Framework;
using System.Diagnostics;
using System.Collections.Generic;

namespace HW2
{
    [TestFixture]
    public class JournalNUnitTests
    {
        public static List<string> names { get { return DataGetterFromExcel.GetNamesOfJournals(Convert.ToInt16(TestData.BatchNumber)); } }

        [Test]
        [TestCaseSource("names")]
        public void MethodTests(string journal)
        {
            Steps.OpenJournal(journal);
            List<NavigationItem> naviItems = DataGetterFromExcel.GetNavigationItems(Convert.ToInt16(TestData.BatchNumber), journal);
            foreach (var naviItem in naviItems)
            {
                Assert.True(Steps.CheckItems(naviItem));
            }
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            Steps.End();
        }
    }
}
