using System;
namespace Task1_1
{
	public abstract class ATimeCounter
	{
		public abstract TimeSpan MeasureAddToBegin();
		public abstract TimeSpan MeasureAddToEnd();
		public abstract TimeSpan MeasureReadFromBegin();
		public abstract TimeSpan MeasureReadFromEnd();
		public abstract TimeSpan MeasureRemoveFromBegin();
		public abstract TimeSpan MeasureRemoveFromEnd();
	}
}
