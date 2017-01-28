using System;
using System.Collections.Generic;
namespace Task1_1
{
	public static class Stack
	{
		public static Stack<int> Initialize(int numberOfElements)
		{
			var stack = new Stack<int>();
			for (int i = 0; i < numberOfElements; i++)
			{
				stack.Push(i);
			}
			return stack;
		}

		public static void AddElement(Stack<int> stack, int numberOfElements)
		{
			for (int i = 0; i < numberOfElements; i++)
			{
				stack.Push(i);
			}
		}

		public static int ReadElement(Stack<int> stack)
		{
			//TODO : ReadElement method
			return 0;
		}

		public static void RemoveElement(Stack<int> stack)
		{
			stack.Pop();
		}
	}
}

