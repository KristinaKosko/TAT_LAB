using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task_1_2
{
    public class FibonacciSequenceCreator
    {
        public const int DefaultSequenceLength = 200;

        // public int SequenceLength { get; set; }

        // public List<BigInteger> SequenceList { get; private set; }
        
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
        
        // <summary> 
        // Creates Fibanacci numbers sequence with specefied in constructor length 
        // </summary> 
       /* private void Initialise()
        {
            SequenceList.Add(0);
            SequenceList.Add(1);

            for (var i = 1; i < DefaultSequenceLength - 1; i++)
            {
                SequenceList.Add(SequenceList[i - 1] + SequenceList[i]);
            }
        }*/
    }
}