using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    [TestFixture]
    public class JournalLoginTests
    {
        public static List<Journal> journals = new List<Journal>();
 
        [TestCaseSource("journals")]
        public List<Journal> OpenJournals(Journal journal)
        {
            JournalsFiller.FillJournal(journal, 1, 1);
            return journals;
        }

        [Test]
        public void JournalLoginTest() { 
            foreach (var journal in journals)
            {
                Steps.OpenJournal(journal.name);
                Steps.TryLogin();
            }
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
