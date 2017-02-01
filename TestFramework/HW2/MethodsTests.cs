using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace HW2
{
    [TestFixture]
	public class MethodsTests
	{
        static List<string> names { get {return ExcelParser.GetNamesOfJournals(); } }
        [Test]
        [TestCaseSource("names")]
		public void MethodTests(string journal)
		{
            Steps.OpenJournal(journal);
            List<NavigationItem> naviItems = ExcelParser.GetNavigationItems(journal);
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
