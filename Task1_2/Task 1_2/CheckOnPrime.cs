using System;
using System.Numerics;

namespace Task_1_2
{
    public static class CheckerOnPrime
    {
        public static bool IfPrime(this BigInteger number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}
