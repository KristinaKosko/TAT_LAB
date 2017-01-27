using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1_1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Adding to the top of collections: ");
            AddToTheTop adderTop = new AddToTheTop();
            adderTop.printWorkTimeOfAdding(adderTop.List, adderTop.LinkedList, adderTop.Stack, adderTop.Que, adderTop.SortDict, adderTop.SortSet, adderTop.SortDict);
            Console.WriteLine("\n");

            Console.WriteLine("Adding to the end of collections: ");
            AddToTheEnd adderEnd = new AddToTheEnd();
            adderEnd.printWorkTimeOfAdding(adderEnd.List, adderEnd.LinkedList, adderEnd.Stack, adderEnd.Que, adderEnd.SortDict, adderEnd.SortSet, adderEnd.SortDict);
            Console.WriteLine("\n");

            Console.WriteLine("Reading first elements of collections: ");
            ReadFirstElement getterFirst = new ReadFirstElement();
            getterFirst.printWorkTimeOfAdding(getterFirst.List, getterFirst.LinkedList, getterFirst.Stack, getterFirst.Que, getterFirst.SortDict, getterFirst.SortSet, getterFirst.SortDict);
            Console.WriteLine("\n");

            Console.WriteLine("Reading last elements of collections: ");
            ReadLastElement getterLast = new ReadLastElement();
            getterLast.printWorkTimeOfAdding(getterLast.List, getterLast.LinkedList, getterLast.Stack, getterLast.Que, getterLast.SortDict, getterLast.SortSet, getterLast.SortDict);
            Console.WriteLine("\n");

            Console.WriteLine("Removing first elements from collections: ");
            RemoveFirstElement removeFirst = new RemoveFirstElement();
            removeFirst.printWorkTimeOfAdding(removeFirst.List, removeFirst.LinkedList, removeFirst.Stack, removeFirst.Queue, removeFirst.SortDict, removeFirst.SortSet, removeFirst.SortDict);
            Console.WriteLine("\n");

            Console.WriteLine("Removing last elements from collections: ");
            RemoveLastElement removeLast = new RemoveLastElement();
            removeLast.printWorkTimeOfAdding(removeLast.List, removeLast.LinkedList, removeLast.Stack, removeLast.Que, removeLast.SortDict, removeLast.SortSet, removeLast.SortDict);


            Console.WriteLine("\n Press any key to exit");
            Console.ReadLine();
        }
    }
}

    
