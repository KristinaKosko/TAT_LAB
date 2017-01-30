using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
    public static class CounterSqrtOfNumsWTwo
    {
        public static bool HasTwo(this BigInteger number)
        {
			BigInteger buffNum = number;
            bool ifHasDigit = false;
            int digitToCheck = 2;

            while (buffNum > 0)
            {
				BigInteger rem;
                rem = buffNum % 10;
                if (rem == digitToCheck)
                {
                    return (ifHasDigit = true);
                }
            }
            return ifHasDigit;
        }

		public static BigInteger CountSqrt(this BigInteger number)
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

