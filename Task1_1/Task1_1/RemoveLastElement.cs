using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    class RemoveLastElement
    {
        private List<int> list = new List<int>();
        private LinkedList<int> linkedList = new LinkedList<int>();
        private Dictionary<int, int> dict = new Dictionary<int, int>();
        private Queue<int> que = new Queue<int>();
        private Stack<int> stack = new Stack<int>();
        private SortedSet<int> sortSet = new SortedSet<int>();
        private SortedDictionary<int, int> sortDict = new SortedDictionary<int, int>();
        private int QUANT_STEPS = 10000000;

        public void printWorkTimeOfAdding(List<int> list, LinkedList<int> lList, Stack<int> stack, Queue<int> queue,
            IDictionary<int, int> dict, SortedSet<int> sortSet, SortedDictionary<int, int> sortDict)
        {
            list.Add(1);
            list.Add(1);
            lList.AddFirst(1);
            lList.AddLast(2);
            dict.Add(1, 1);
            que.Enqueue(1);
            que.Enqueue(2);
            stack.Push(1);
            stack.Push(2);
            sortSet.Add(1);
            sortSet.Add(2);
            sortDict.Add(0, 1);

            Stopwatch topWatch = Stopwatch.StartNew();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                list.Remove((list.Count)-1);
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds) + " ms List");


            topWatch.Reset();
            topWatch.Start();

            for (int i = 0; i < QUANT_STEPS; i++)
            {
                lList.Remove((lList.Count) - 1);
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds) + " ms Linked List");


            topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < 1; i++)
            {
                stack.Pop();
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds) + " ms Stack");


            /*topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                queue.Last();
            }
            topWatch.Stop();*/
            Console.WriteLine(/*Convert.ToString(topWatch.ElapsedMilliseconds)*/ "not supported in Queue");


            topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                dict.Remove((dict.Count) - 1);
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds) + " ms Dictionary");


            topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                sortSet.Remove((sortSet.Count) - 1);
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds) + " ms Sorted Set");


            topWatch.Reset();
            topWatch.Start();
            for (int i = 0; i < QUANT_STEPS; i++)
            {
                if (!sortDict.ContainsKey(i))
                {
                    sortDict.Remove((sortDict.Count) - 1);
                }
            }
            topWatch.Stop();
            Console.WriteLine(Convert.ToString(topWatch.ElapsedMilliseconds) + " ms Sorted Dictionary");
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
