using System;
using System.Collections.Generic;
using System.Numerics;
using NUnit.Framework;

namespace Task_1_2
{
	[TestFixture]
	public class TestFibonacciSequence
	{
		private List<BigInteger> fibonacciSeq;

		[SetUp]
		public void SetUp()
		{
			fibonacciSeq = new FibonacciSequenceCreator();
		}

		[Test]
		public void TestIfPrimal()
		{
			Console.WriteLine(WorkerWithFibonacciSequence.CountPrimes(fibonacciSeq));
		}

		[Test]
		public void TestIfDivByFive()
		{
			Console.WriteLine(WorkerWithFibonacciSequence.IfDivByFive(fibonacciSeq));
		}

		[Test]
		public void TestIfDivOnSumOfNums()
		{
			Console.WriteLine(WorkerWithFibonacciSequence.IfDivOnSumOfNums(fibonacciSeq));
		}

		[Test]
		public void TestRootsOfNumsWithDigitTwo()
		{
			Console.WriteLine(WorkerWithFibonacciSequence.RootsOfNumsWTwo(fibonacciSeq));
		}
	}
}
