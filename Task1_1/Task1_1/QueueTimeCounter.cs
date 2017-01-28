using System;
using System.Diagnostics;
namespace Task1_1
	{
		public class QueueTimeCounter : ATimeCounter
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
				Queue.AddElement(Queue.Initialize(elementsNumber), elementsNumber);
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureReadFromEnd()
			{
				return new TimeSpan(-1);
			}

			public override TimeSpan MeasureReadFromBegin()
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				Queue.ReadElement(Queue.Initialize(elementsNumber));
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureRemoveFromBegin()
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				Queue.RemoveElement(Queue.Initialize(elementsNumber));
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureRemoveFromEnd()
			{
				return new TimeSpan(-1);
			}
		}
	}