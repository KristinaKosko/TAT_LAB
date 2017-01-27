using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    class AddToTheTop { 
        private List<int> list = new List<int>();
        private LinkedList<int> linkedList = new LinkedList<int>();
        private Dictionary<int, int> dict = new Dictionary<int, int>();
        private Queue<int> que = new Queue<int>();
        private Stack<int> stack = new Stack<int>();
        private SortedSet<int> sortSet = new SortedSet<int>();
        private SortedDictionary<int, int> sortDict = new SortedDictionary<int, int>();
        private int QUANT_STEPS = 1000000; 

        public void printWorkTimeOfAdding(List<int> list, LinkedList<int> lList, Stack<int> stack, Queue<int> queue,
            IDictionary<int, int> dict, SortedSet<int> sortSet, SortedDictionary<int, int> sortDict)
        {
            Stopwatch topWatch = Stopwatch.StartNew();
            topWatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                list.Insert(0,2);
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds)+ "ms List");


            topWatch.Reset();
            topWatch.Start();

            for (int i = 0; i < QUANT_STEPS; i++)
            { 
                lList.AddFirst(2);
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds) + "ms Linked List");


            topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                stack.Push(2);
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds) + " ms Stack");


            /* topWatch.Reset();
             topWatch.Start();
             for (int i = 0; i < QUANT_STEPS; i++)
             {
                 stack.Enqueue(2);
             }
             topWatch.Stop(); */
            Console.WriteLine(/*Convert.ToString(topWatch.ElapsedMilliseconds)*/ "not supported in Queue");


            /*topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                dict.Add(i, 2);
            }
            topWatch.Stop(); */
            Console.WriteLine(/*Convert.ToString(topWatch.ElapsedMilliseconds)*/ "not supported in Dictionary");


            /*topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                sortSet.Add(2);
            }
            topWatch.Stop(); */
            Console.WriteLine(/*Convert.ToString(topWatch.ElapsedMilliseconds)*/ "not supported in Sorted Set");


            /*topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                if(!sortDict.ContainsKey(i))
                {
                    sortDict.Add(i, 2);
                }
            }
            topWatch.Stop();*/
            Console.WriteLine(/*Convert.ToString(topWatch.ElapsedMilliseconds)*/ "not supported in Sorted Dictionary");
        }

        public List<int> List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }

        public LinkedList<int> LinkedList
        {
            get
            {
                return linkedList;
            }

            set
            {
                linkedList = value;
            }
        }

        public Dictionary<int, int> Dict
        {
            get
            {
                return dict;
            }

            set
            {
                dict = value;
            }
        }

        public Queue<int> Que
        {
            get
            {
                return que;
            }

            set
            {
                que = value;
            }
        }

        public Stack<int> Stack
        {
            get
            {
                return stack;
            }

            set
            {
                stack = value;
            }
        }

        public SortedSet<int> SortSet
        {
            get
            {
                return sortSet;
            }

            set
            {
                sortSet = value;
            }
        }

        public SortedDictionary<int, int> SortDict
        {
            get
            {
                return sortDict;
            }

            set
            {
                sortDict = value;
            }
        }
    }
}
