using System;
using System.Diagnostics;
namespace Task1_1
{
	public class DictionaryTimeCounter : ATimeCounter
	{
		public int elementsNumber = 100000;
		public override TimeSpan MeasureAddToBegin()
		{
			return new TimeSpan(-1);
		}

		public override TimeSpan MeasureAddToEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			Dictionary.AddElement(Dictionary.Initialize(elementsNumber), elementsNumber);
			return stopwatch.Elapsed;
		}

		public override TimeSpan MeasureReadFromEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			Dictionary.ReadElement(Dictionary.Initialize(elementsNumber), elementsNumber - 1);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureReadFromBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			Dictionary.ReadElement(Dictionary.Initialize(elementsNumber), 0);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureRemoveFromBegin()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			Dictionary.RemoveElement(Dictionary.Initialize(elementsNumber), 0);
			return (stopwatch.Elapsed);
		}

		public override TimeSpan MeasureRemoveFromEnd()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			Dictionary.RemoveElement(Dictionary.Initialize(elementsNumber), elementsNumber - 1);
			return (stopwatch.Elapsed);
		}
	}
}