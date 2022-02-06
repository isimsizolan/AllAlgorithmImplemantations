using System;
using AllAlgorithmImplemantations.Sorting;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 0,5,2,1,4,56,3,12,5,6,78};
            arr.HeapSort();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}