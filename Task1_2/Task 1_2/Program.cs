using System;
using System.Collections.Generic;
using System.Numerics;

namespace Task_1_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<BigInteger> sequenceFibonacci = new List<BigInteger>();
            sequenceFibonacci = FibonacciSequenceCreator.FibonacciSequence();
			CollectionPrinter.PrintCollection(sequenceFibonacci);
            Console.ReadKey(true);
        }
    }
}
