using System;
using System.Collections.Generic;

namespace Task1_1
{
	public static class List
	{

		public static List<int> ListInitialize(int numberOfElements)
		{
			var list = new List<int>();
			for (var i = 0; i < numberOfElements; i++)
			{
				list.Add(i);
			}
			return list;
		}

		public static void AddElement(List<int> list, int numberOfElements, bool addToBegin)
		{
			for (int i = 0; i < numberOfElements; i++)
			{
				if (addToBegin)
				{
					list.Insert(0, i);
				}
				else
				{
					list.Add(i);
				}
			}
		}

		public static int ReadElement(List<int> list, bool readFirst)
		{
			return list[readFirst ? 0 : list.Count - 1];
		}

		public static void RemoveElement(List<int> list, bool removeFirst)
		{
			list.RemoveAt(removeFirst ? 0 : list.Count - 1);
		}
	}
