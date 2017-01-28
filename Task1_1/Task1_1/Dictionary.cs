using System;
using System.Collections.Generic;
namespace Task1_1
{
	public static class Dictionary
	{
		public static Dictionary<int, int> Initialize(int numberOfElements)
		{
			var dictionary = new Dictionary<int, int>();
			for (int i = 0; i < numberOfElements; i++)
			{
				dictionary.Add(i, i+1);
			}
			return dictionary;
		}

		public static void AddElement(Dictionary<int, int> dictionary, int numberOfElements)
		{
			for (int i = 0; i < numberOfElements; i++)
			{
				dictionary.Add(-1 - i, -i);
			}
		}

		public static int ReadElement(Dictionary<int, int> dictionary, int index)
		{
			return dictionary[index];
		}

		public static void RemoveElement(Dictionary<int, int> dictionary, int index)
		{
			dictionary.Remove(index);
		}
	}
}
