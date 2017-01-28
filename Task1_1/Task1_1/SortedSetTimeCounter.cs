using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Task1_1
{
	public class SortedSetTimeCounter : ATimeCounter
	{
		public int elementsNumber = 100000;
		public override TimeSpan MeasureAddToBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedSet.AddElement(SortedSet.Initialize(elementsNumber), elementsNumber, true);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureAddToEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedSet.AddElement(SortedSet.Initialize(elementsNumber), elementsNumber, false);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureReadFromEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedSet.ReadElement(SortedSet.Initialize(elementsNumber), false);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureReadFromBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedSet.ReadElement(SortedSet.Initialize(elementsNumber), true);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureRemoveFromBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedSet.RemoveElement(SortedSet.Initialize(elementsNumber), true);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureRemoveFromEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedSet.RemoveElement(SortedSet.Initialize(elementsNumber), false);
			return (stopwatch.Elapsed);
		}
	}
}