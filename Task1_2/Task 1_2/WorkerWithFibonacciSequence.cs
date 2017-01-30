using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task_1_2
{
	public static class WorkerWithFibonacciSequence
	{
		public static BigInteger CountPrimes(ICollection<BigInteger> sequenceFibonacci)
		{
			return sequenceFibonacci.Count(s => s.IsPrimal());
		}

		public static bool IfDivByFive(ICollection<BigInteger> sequenceFibonacci)
		{
			return sequenceFibonacci.Any(i => i.IfCanBeDivByNumber(5));
		}

		public static BigInteger IfDivOnSumOfNums(ICollection<BigInteger> sequenceFibonacci)
		{
			return sequenceFibonacci.Count(s => s.TryDivOnSumOfDigits());
		}

		public static List<BigInteger> RootsOfNumsWTwo(ICollection<BigInteger> sequenceFibonacci)
		{
			return (from element in sequenceFibonacci where element.HasTwo() select element.CountSqrt()).ToList();
		}
	}
}
