using System;
using System.Collections.Generic;

namespace Task1_1
{
	public static class SortedDictionary
	{

		public static SortedDictionary<int, int> Initialize(int numberOfElements)
		{
			var sortedDictionary = new SortedDictionary<int, int>();
			for (var i = 0; i < numberOfElements; i++)
			{
				sortedDictionary.Add(i, i + 1);
			}
			return sortedDictionary;
		}

		public static void AddElement(SortedDictionary<int, int> sortedDictionary, int numberOfElements, bool addToBegin)
		{
			for (var i = 0; i < numberOfElements; i++)
			{
				if (addToBegin)
				{
					sortedDictionary.Add(-1 - i, -i);
				}
				else
				{
					sortedDictionary.Add(int.MaxValue - i, i);
				}
			}
		}

		public static int ReadElement(SortedDictionary<int, int> sortedDictionary, bool readInBegin)
		{
			return readInBegin ? sortedDictionary[0] : sortedDictionary[sortedDictionary.Count - 1];
		}

		public static void RemoveElement(SortedDictionary<int, int> sortedDictionary, bool removeInBegin)
		{
			if (removeInBegin)
			{
				sortedDictionary.Remove(0);
			}
			else
			{
				sortedDictionary.Remove(sortedDictionary.Count - 1);
			}
		}
	}
}