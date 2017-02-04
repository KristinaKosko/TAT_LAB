using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    [TestFixture]
    class JournalLoginTests
    {
        static List<Journal> journals = new List<Journal>();
 
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
                TryLogin();
            }
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }

        public static void TryLogin()
        {
            var journalLoginPage = new JournalLoginPage();
            journalLoginPage.GoToLogin();
            journalLoginPage.Login("avkozlov_by", "Minsk2017");
        }
    }
}
