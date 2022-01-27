using System;
using AllAlgorithmImplemantations.Sorting;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1,2,3,4,5,6,7 };

            arr = arr.QuickSort();


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}