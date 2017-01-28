using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1_1
{
	public class CollectionsTester
	{
		public string path = "@Desktop\\TestResult.txt";
		private List<ATimeCounter> InitCollectionTimeCounters()
		{
			var timeTests = new List<ATimeCounter>
			{
				new ListTimeCounter(),
				new LinkedListTimeCounter(),
				new DictionaryTimeCounter(),
				new QueueTimeCounter(),
				new StackTimeCounter(),
				new SortedSetTimeCounter(),
				new SortedDictionaryTimeCounter()
			};

			return timeTests;
		}

		public void SpeedTest()
		{
			var timeTests = InitCollectionTimeCounters();

			foreach (var test in timeTests)
			{
				var testTimes = new List<TimeSpan>
				{
					test.MeasureAddToBegin(),
					test.MeasureAddToEnd(),
					test.MeasureReadFromBegin(),
					test.MeasureReadFromEnd(),
					test.MeasureRemoveFromBegin(),
					test.MeasureRemoveFromEnd(),
				};
				var testResult = new List<string>();
				testResult.AddRange(testTimes.Select(time => time.Ticks == -1 ? "-" : time.TotalMilliseconds.ToString()));
				var writer = new WriterToFile();
				foreach (var time in testResult)
				{
					writer.Write(path, time);
				}
			}
		}
	}
}
