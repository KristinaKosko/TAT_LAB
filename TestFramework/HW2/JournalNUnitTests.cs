using System;
using NUnit.Framework;
using System.Diagnostics;
using System.Collections.Generic;

namespace HW2
{
    [TestFixture]
    public class JournalNUnitTests
    {
        static List<string> names { get { return ExcelParser.GetNamesOfJournals(); } }
        [Test]
        [TestCaseSource("names")]
        public void MethodTests(string journal)
        {
            Steps.OpenJournal(journal);
            List<NavigationItem> naviItems = ExcelParser.GetNavigationItems(journal);
            ExcelParser.ExcelKill();
            foreach (var naviItem in naviItems)
            {
                Assert.True(Steps.CheckItems(naviItem));
            }
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            Steps.End();
            //foreach (var p in Process.GetProcessesByName("Excel"))
            //  p.Kill();
            // foreach (var p in Process.GetProcessesByName("ChromeDriver"))
            //   p.Kill();
        }
    }
}
