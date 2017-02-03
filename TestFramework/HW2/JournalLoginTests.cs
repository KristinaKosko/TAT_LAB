using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class JournalLoginTests
    {
        public static void OpenJournals(List<Journal> journals)
        {
            foreach (var journal in journals)
            {
                JournalsFiller.FillJournal(journal, 1, 1);
            }

            foreach (var journal in journals)
            {
                Steps.OpenJournal(journal.name);
                //TODO Checking ability of loging
            }
        }
    }
}
