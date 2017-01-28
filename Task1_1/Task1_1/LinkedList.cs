using System;
using System.Collections.Generic;

namespace Task1_1
{
	public static class LinkedList
	{
		public static  LinkedList<int> Initialize(int numberOfElements)
		{
			var list = new LinkedList<int>();
			for (int i = 0; i < numberOfElements; i++)
			{
				list.AddLast(i);
			}
			return list;
		}

		public static void AddElement(LinkedList<int> linkedList, int numberOfElements, bool addFirst)
		{
			for (int i = 0; i < numberOfElements; i++)
			{
				if (addFirst)
				{
					linkedList.AddFirst(i);
				}
				else
				{
					linkedList.AddLast(i);
				}
			}
		}

		public static int ReadElement(LinkedList<int> linkedList, bool readFirst)
		{
			return (readFirst ? linkedList.First.Value : linkedList.Last.Value);
		}

		public static void RemoveElement(LinkedList<int> linkedList, bool removeFirst)
		{
			linkedList.Remove(removeFirst ? linkedList.First : linkedList.Last);
		}
	}
}
