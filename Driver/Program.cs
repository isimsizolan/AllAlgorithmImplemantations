using System;
using AllAlgorithmImplemantations.Sorting;
using AllAlgorithmImplemantations.Searching;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 0,5,2,1,4,56,3,12,5,6,78};
            arr.QuickSort();


            //foreach (var item in arr)
            //{
            //    Console.Write(" " + item);
            //}

            int x = 5;
            if (arr.BinarySearch(x) > -1)
                Console.WriteLine($"Found at location: {x}");

            //Console.WriteLine();
            //Console.WriteLine(arr.BinarySearch(5));

        }
    }
}