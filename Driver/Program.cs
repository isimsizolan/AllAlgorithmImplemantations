using System;
using AllAlgorithmImplemantations.Sorting;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 5, 1, 1, 12, 3 ,0 };

            arr = arr.QuickSort();


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}