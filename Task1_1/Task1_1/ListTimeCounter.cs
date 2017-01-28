using System;
using System.Diagnostics;
namespace Task1_1
{
	public class ListTimeCounter : ATimeCounter
	{
		public int elementsNumber = 100000;
		public override TimeSpan MeasureAddToBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			List.AddElement(List.ListInitialize(elementsNumber), elementsNumber, true);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureAddToEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			List.AddElement(List.ListInitialize(elementsNumber), elementsNumber, false);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureReadFromEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			List.ReadElement(List.ListInitialize(elementsNumber), false);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureReadFromBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			List.ReadElement(List.ListInitialize(elementsNumber), true);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureRemoveFromBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			List.RemoveElement(List.ListInitialize(elementsNumber), true);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureRemoveFromEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			List.RemoveElement(List.ListInitialize(elementsNumber), false);
			return stopwatch.Elapsed;
		}
	}
}