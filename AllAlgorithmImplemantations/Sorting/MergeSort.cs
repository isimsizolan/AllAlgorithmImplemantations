using System;
using System.Collections.Generic;
using System.Text;

namespace AllAlgorithmImplemantations.Sorting
{
    public static class MergeSortExtension
    {
        public static int[] MergeSort(this int[] arr)
        {
            int[] aux = new int[arr.Length];
            sort(arr, aux, 0, arr.Length-1);
            return arr;
        }

        public static void sort(int[] arr, int[] aux, int low, int high)
        {
            if (high <= low)
                return;
            int mid = low + (high - low) / 2;
            sort(arr, aux, low, mid);
            sort(arr, aux, mid + 1, high);
            merge(arr, aux, low, mid, high);
        }

        public static void merge(int[] arr, int[] aux, int low, int mid, int high)
        {
            int i = low;
            int j = mid + 1;

            for (int k = low; k <= high; k++)
                aux[k] = arr[k];

            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                    arr[k] = aux[j++];
                else if (j > high)
                    arr[k] = aux[i++];
                else if (aux[i] < aux[j])
                    arr[k] = aux[i++];
                else
                    arr[k] = aux[j++];
            }
        }
    }
}
