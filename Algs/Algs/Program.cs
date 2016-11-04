using System;
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

            Console.WriteLine("Index of element 8 is: {0}", BinarySearch.Find(sortedArray, 8));

            Console.ReadKey();
        }
    }
}
