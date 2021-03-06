﻿using System;
using System.Collections.Generic;

namespace HW2
{
	public static class JournalsFiller
	{
		public static List<Journal> FillJournal(Journal journal, int index, int amount)
		{
			List<Journal> journals = new List<Journal>();
			List<string> namesOfJournals = DataGetterFromExcel.namesOfJournals;
			if ((amount-1) + index > namesOfJournals.Capacity) amount = (namesOfJournals.Capacity - index);
			for (int i = index; i < amount; i++)
			{
					journal.name = namesOfJournals[i];
					journal.navigationItems = DataGetterFromExcel.GetNavigationItems(Convert.ToInt16(TestData.BatchNumber), journal.name);
					journals.Add(journal);
			}
			return journals;
		}
	}
}
