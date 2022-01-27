using System;
using System.Collections.Generic;
using System.Text;

namespace AllAlgorithmImplemantations.Sorting
{
    public static class InsertionSortExtention
    {
        public static void InsertionSort(this int[] arr)
        {

            int i;
            int j;

            for (i = 1; i < arr.Length; i++)
            {
                for(j = i; j>0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int tmp = arr[j-1];
                        arr[j-1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

        }
    }
}