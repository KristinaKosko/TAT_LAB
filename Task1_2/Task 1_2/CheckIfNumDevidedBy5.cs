using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
    public static class CheckerIfNumDevidedByNumber
    {
		public static bool IfCanBeDivByNumber(this BigInteger number, int digit)
        {
            if (number % digit == 0) return true;
            else return false;
        }
    }
}
