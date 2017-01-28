using System;
using System.Collections.Generic;

namespace Task1_1
{
	public static class SortedSet
	{
		public static SortedSet<int> Initialize(int numberOfElements)
		{
			var sortedSet = new SortedSet<int>();
			for (var i = 0; i < numberOfElements; i++)
			{
				sortedSet.Add(i);
			}
			return sortedSet;
		}

		public static void AddElement(SortedSet<int> sortedSet, int numberOfElements, bool addToBegin)
		{
			for (var i = 0; i < numberOfElements; i++)
			{
				if (addToBegin)
				{
					sortedSet.Add(-1 - i);
				}
				else
				{
					sortedSet.Add(int.MaxValue - i);
				}
			}
		}

		public static int ReadElement(SortedSet<int> sortedSet, bool readInBegin)
		{
			return readInBegin ? sortedSet.ElementAt(0) : sortedSet.ElementAt(sortedSet.Count - 1);
		}

		public static void RemoveElement(SortedSet<int> sortedSet, bool removeInBegin)
		{
			if (removeInBegin)
			{
				sortedSet.Remove(0);
			}
			else
			{
				sortedSet.Remove(sortedSet.Count - 1);
			}
		}
	}
}