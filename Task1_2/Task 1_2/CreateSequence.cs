using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task_1_2
{
    public static class FibonacciSequenceCreator
    {
        public const int DefaultSequenceLength = 200;
        
        public static List<BigInteger> FibonacciSequence()
        {
            List<BigInteger> SequenceList = new List<BigInteger>();
            BigInteger ord1 = 0, ord2 = 0, ord3 = 0;
            IEnumerable<BigInteger> FibSeries = Enumerable.Range(1, DefaultSequenceLength).Select(a =>
            {
                ord1 = a == 1 ? 0 : ord2;
                ord2 = a == 1 ? 1 : ord3;
                ord3 = a == 1 ? 0 : ord1 + ord2;
                return ord3;
            });

            foreach (BigInteger elem in FibSeries)
            {
                SequenceList.Add(elem);

            }

            return SequenceList;
        }
    }
}