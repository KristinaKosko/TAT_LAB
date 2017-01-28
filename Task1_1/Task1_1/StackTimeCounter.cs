using System;
	using System.Diagnostics;
	namespace Task1_1
	{
		public class StackTimeCounter : ATimeCounter
		{
			public int elementsNumber = 100000;
			public override TimeSpan MeasureAddToBegin()
			{
			var stopwatch = new Stopwatch();
				stopwatch.Start();
				Stack.AddElement(Stack.Initialize(elementsNumber), elementsNumber);
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureAddToEnd()
			{

				return new TimeSpan(-1);
			}

			public override TimeSpan MeasureReadFromEnd()
			{
			var stopwatch = new Stopwatch();
				stopwatch.Start();
				Stack.ReadElement(Stack.Initialize(elementsNumber));
				return stopwatch.Elapsed;
			}

			public override TimeSpan MeasureReadFromBegin()
			{
				return new TimeSpan(-1);
			}

			public override TimeSpan MeasureRemoveFromBegin()
			{
				return new TimeSpan(-1);
			}

			public override TimeSpan MeasureRemoveFromEnd()
			{
			var stopwatch = new Stopwatch();
				stopwatch.Start();
				Stack.RemoveElement(Stack.Initialize(elementsNumber));
				return stopwatch.Elapsed;
			}
		}
	}
