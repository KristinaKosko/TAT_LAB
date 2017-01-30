using System;
using System.Numerics;

namespace Task_1_2
{
    public static class CheckerOnPrime
    {
        public static bool IsPrimal(this BigInteger number)
		{
			BigInteger i1, i2, i3, i4, i5, i6, i7, i8, bound;
			if (number == 0 || number == 1)
			{
				Console.WriteLine("{0} is NOT primal", number);
				return false;
			}

			if (number == 2 || number == 3 || number == 5 || number == 7 || number == 11 || number == 13 || number == 17 ||
				number == 19 || number == 23 || number == 29)
			{
				Console.WriteLine("{0} is primal", number);
				return true;
			}
			if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0 || number % 11 == 0 ||
				number % 13 == 0 || number % 17 == 0 || number % 19 == 0 || number % 23 == 0 || number % 29 == 0)
			{
				Console.WriteLine("{0} is NOT primal", number);
				return false;
			}
			bound = number.Sqrt();

			i1 = 31; i2 = 37; i3 = 41; i4 = 43; i5 = 47; i6 = 49; i7 = 53; i8 = 59;

			while (i8 <= bound && number % i1 != 0 && number % i2 != 0 && number % i3 != 0 && number % i4 != 0 && number % i5 != 0 && number % i6 != 0 && number % i7 != 0 && number % i8 != 0)
			{
				i1 += 30; i2 += 30; i3 += 30; i4 += 30; i5 += 30; i6 += 30; i7 += 30; i8 += 30;
			}
			if (i8 <= bound ||
				i1 <= bound && number % i1 == 0 ||
				i2 <= bound && number % i2 == 0 ||
				i3 <= bound && number % i3 == 0 ||
				i4 <= bound && number % i4 == 0 ||
				i5 <= bound && number % i5 == 0 ||
				i6 <= bound && number % i6 == 0 ||
				i7 <= bound && number % i7 == 0)
			{
				Console.WriteLine("{0} is NOT primal", number);
				return false;
			}

			Console.WriteLine("{0} is primal", number);
			return true;
		}

		public static BigInteger Sqrt(this BigInteger number)
		{
			if (number == 0) return 0;
			if (number > 0)
			{
				int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(number, 2)));
				var root = BigInteger.One << (bitLength / 2);

				while (!IsSqrt(number, root))
				{
					root += number / root;
					root /= 2;
				}

				return root;
			}

			throw new ArithmeticException("NaN");
		}

		private static bool IsSqrt(BigInteger n, BigInteger root)
		{
			BigInteger lowerBound = root * root;
			BigInteger upperBound = (root + 1) * (root + 1);

			return (n >= lowerBound && n < upperBound);
		}
    }
}
