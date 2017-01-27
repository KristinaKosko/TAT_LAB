using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
    public static class CheckerIfNumDevidedByNumber
    {
        public static bool IfCanBeDivByNumber(this int number, int digit)
        {
            if (number % digit == 0) return true;
            else return false;
        }
    }
}
