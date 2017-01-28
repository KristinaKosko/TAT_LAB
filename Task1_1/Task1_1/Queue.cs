using System;
using System.Collections.Generic;
namespace Task1_1
{
	public static class Queue
	{
		public static Queue<int> Initialize(int numberOfElements)
		{
			var queue = new Queue<int>();
			for (int i = 0; i < numberOfElements; i++)
			{
				queue.Enqueue(i);
			}
			return queue;
		}

		public static void AddElement(Queue<int> queue, int numberOfElements)
		{
			for (int i = 0; i < numberOfElements; i++)
			{
				queue.Enqueue(i);
			}
		}

		public static int ReadElement(Queue<int> queue)
		{
			return queue.Peek();
		}

		public static void RemoveElement(Queue<int> queue)
		{
			queue.Dequeue();
		}
	}
}
