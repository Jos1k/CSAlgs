using System;
using DataStructures.LinkedList;
using Misc;
using Searching.Algorithms;
using Sorting.Algorithms;

namespace Algs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 1, 5, 15, 3, 13, 6, 9, 10, 4, 8, 2 };
            Console.WriteLine("Initial array: {0} \n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n",
                inputArray.ArrayToString()
            );
            Console.WriteLine("- - - - - - - - - - - - - - -- - - - - Sorting - - - - - - - - - - - - -- - ");

            Console.WriteLine("Inserting sort: {0} \n", InsertingSort.Sort(inputArray).ArrayToString());
            Console.WriteLine("Shell sort: {0} \n", ShellSort.Sort(inputArray).ArrayToString());
            Console.WriteLine("Quick sort: {0} \n", QuickSort.Sort(inputArray).ArrayToString());
            Console.WriteLine("Merge sort: {0} \n", MergeSort.Sort(inputArray).ArrayToString());

            Console.WriteLine("- - - - - - - - - - - - - - -- - - - - Searching - - - - - - - - - - - - -- - ");

            int[] sortedArray = QuickSort.Sort(inputArray);

            Console.WriteLine("Index of element 8 is: {0} \n", BinarySearch.Find(sortedArray, 8));

            Console.WriteLine("- - - - - - - - - - - - - - -- - - - - Queue from 2 stacks - - - - - - - - - - - - -- - ");
            QueueFromTwoStacks queue = new QueueFromTwoStacks();

            foreach (var i in sortedArray)
            {
                queue.Enqueue(i);
            }

            string queueStr = string.Empty;
            while (true)
            {
                int val = queue.Dequeue();
                if (val == -1)
                {
                    break;
                }
                queueStr += val + " ";
            }
            Console.WriteLine("Queue: {0} \n", queueStr);

			Console.WriteLine( "- - - - - - - - - - - - - - -- - - - - Stack from 2 queues - - - - - - - - - - - - -- - " );
			StackFromTwoQueues stack = new StackFromTwoQueues();

			foreach( var i in sortedArray ) {
				stack.Push( i );
			}

			string stackStr = string.Empty;
			while( true ) {
				int val = stack.Pop();
				if( val == -1 ) {
					break;
				}
				stackStr += val + " ";
			}
			Console.WriteLine( "Stack: {0} \n", stackStr );


			Console.WriteLine( "- - - - - - - - - - - - - - -- - - - - Linked list - - - - - - - - - - - - - - - " );

			LLOneDirection<int> linkedList = new LLOneDirection<int>();

			foreach( var item in sortedArray ) {
				linkedList.Add( item );
			}

			Console.WriteLine( "Linked list result: {0} \n", linkedList.ToArray().ArrayToString());

			linkedList.RemoveFirst();
			linkedList.RemoveLast();
			Console.WriteLine( "Linked list result (after removing first and last ): {0} \n", linkedList.ToArray().ArrayToString() );

            Console.ReadKey();
        }
    }
}
