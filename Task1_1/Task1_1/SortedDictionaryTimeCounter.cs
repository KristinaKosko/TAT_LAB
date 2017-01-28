using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Task1_1
{
	public class SortedDictionaryTimeCounter : ATimeCounter
	{
		public int elementsNumber = 100000;
		public override TimeSpan MeasureAddToBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedDictionary.AddElement(SortedDictionary.Initialize(elementsNumber), elementsNumber, true);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureAddToEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedDictionary.AddElement(SortedDictionary.Initialize(elementsNumber), elementsNumber, false);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureReadFromEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedDictionary.ReadElement(SortedDictionary.Initialize(elementsNumber), false);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureReadFromBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedDictionary.ReadElement(SortedDictionary.Initialize(elementsNumber), true);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureRemoveFromBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedDictionary.RemoveElement(SortedDictionary.Initialize(elementsNumber), true);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureRemoveFromEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			SortedDictionary.RemoveElement(SortedDictionary.Initialize(elementsNumber), false);
			return (stopwatch.Elapsed);
		}
	}
}