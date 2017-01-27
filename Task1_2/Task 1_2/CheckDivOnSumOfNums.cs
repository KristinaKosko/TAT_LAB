using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace Task_1_2
{
    public static class CheckerDivOnSumOfDigits
    {
        public static bool TryDivOnSumOfDigits(this BigInteger number)
        {
            return number == 0 ? false : number % number.ToString().Sum(digit => int.Parse(digit.ToString())) == 0;
        }
    }
}
