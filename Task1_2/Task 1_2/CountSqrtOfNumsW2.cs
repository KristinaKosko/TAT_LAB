using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
    public static class CounterSqrtOfNumsWTwo
    {
        public static bool HasTwo(this int number)
        {
            int buffNum = number;
            bool ifHasDigit = false;
            int digitToCheck = 2;

            while (buffNum > 0)
            {
                int rem;
                buffNum = Math.DivRem(buffNum, 10, out rem);
                if (rem == digitToCheck)
                {
                    return (ifHasDigit = true);
                }
            }
            return ifHasDigit;
        }

        public static double CountSqrt(this int number)
        {
            double sqrt = Math.Floor(Math.Sqrt(number));
            return sqrt;
        }
    }
}

