using System;
using System.Collections.Generic;
using System.Text;

namespace AllAlgorithmImplemantations.Sorting
{
    public static class SelectionSortExtention
    {
        public static int[] SelectionSort(this int[] arr )
        {

            int N = arr.Length;
            int min;

            for (int i = 0; i < N; i++)
            {
                min = i;
                for (int j = i; j < N; j++)
                {
                    min = arr[j] < arr[min] ? j : min;
                }

                int tmp = arr[i];
                arr[i] = arr[min];
                arr[min] = tmp;
            }

            return arr;
        }
    }
}
