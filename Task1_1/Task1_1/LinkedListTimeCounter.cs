using System;
	using System.Diagnostics;
	namespace Task1_1
	{
		public class LinkedListTimeCounter : ATimeCounter
		{
			public int elementsNumber = 100000;
			public override TimeSpan MeasureAddToBegin()
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				LinkedList.AddElement(LinkedList.Initialize(elementsNumber), elementsNumber, true);
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureAddToEnd()
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				LinkedList.AddElement(LinkedList.Initialize(elementsNumber), elementsNumber, false);
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureReadFromEnd()
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				LinkedList.ReadElement(LinkedList.Initialize(elementsNumber), false);
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureReadFromBegin()
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				LinkedList.ReadElement(LinkedList.Initialize(elementsNumber), true);
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureRemoveFromBegin()
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				LinkedList.RemoveElement(LinkedList.Initialize(elementsNumber), true);
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureRemoveFromEnd()
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				LinkedList.RemoveElement(LinkedList.Initialize(elementsNumber), false);
				return stopwatch.Elapsed;
			}
		}
	}
