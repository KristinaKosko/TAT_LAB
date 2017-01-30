using System;
using System.Collections.Generic;

namespace Task_1_2
{
	public static class CollectionPrinter
	{
		public static void PrintCollection<T>(ICollection<T> collection)
		{
			foreach (var element in collection)
			{
				Console.WriteLine(element);
			}
		}
	}
}
