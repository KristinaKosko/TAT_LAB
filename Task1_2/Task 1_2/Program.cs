using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Task_1_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<BigInteger> sequenceFibonacci = new List<BigInteger>();
            List<double> sqrts = new List<double>();
            sequenceFibonacci = FibonacciSequenceCreator.FibonacciSequence();
            foreach (BigInteger number in sequenceFibonacci)
            {
                Console.WriteLine(number);
            }
            int digit = 5;

           // int countPrimes = sequenceFibonacci.Count(s => s.IfPrime());
            int countNumsDivOnSum = sequenceFibonacci.Count(s => s.TryDivOnSumOfDigits());
            Console.WriteLine("Amount of numbers in the sequence that can be devided on sum of their digits: " + countNumsDivOnSum);
            /*   
           //Console.WriteLine("\n\nNumber of primes in the sequence: " + countPrimes);
           Console.WriteLine("Amount of numbers in the sequence that can be devided on sum of their digits: " + countNumsDivOnSum);
           Console.Write("Numbers that can be divided by 5: ");
           IEnumerable<int> numbers = sequenceFibonacci.Where(s => s.IfCanBeDivByNumber(digit));
           foreach (int number in numbers )
           {
               Console.Write(number + " ");
           }
           Console.Write("\nThe roots of numbers which have digit 2 are: ");
           foreach (int number in sequenceFibonacci)
           {
               if (number.HasTwo())
               {
                   Console.Write(number.CountSqrt().ToString() + " ");
               }
           }*/
            Console.ReadKey(true);
        }
    }
}
