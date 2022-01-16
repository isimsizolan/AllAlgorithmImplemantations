using System;
using AllAlgorithmImplemantations.Sorting;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 5, 1, 1, 12, 3 };

            arr = arr.SelectionSort();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
