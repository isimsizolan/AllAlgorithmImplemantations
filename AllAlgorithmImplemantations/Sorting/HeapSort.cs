using System;
using System.Collections.Generic;
using System.Text;

namespace AllAlgorithmImplemantations.Sorting
{
    public static class HeapSortExtention
    {
        public static void HeapSort(this int[] arr)
        {
            //TODO: array start with index 0, but tree root node start with 1. this is quick but bad solution to fix this.
            int[] temparray = new int [arr.Length+1];
            for (int i = 1; i < arr.Length; i++)
            {
                temparray[i] = arr[i - 1];
            }

            int N = arr.Length;
            for (int i = N/2; i >=1; i--)
            {
                sink(temparray, i, N);
            }
            while(N > 1)
            {
                exch(temparray, 1, N--);
                sink(temparray, 1, N);
            }

            //TODO:
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = temparray[i + 1];
            }
        }

        private static void sink(int[] arr, int i, int n)
        {
            while (i * 2 <= n)
            {
                int j = i*2;
                if (j < n && less(arr[j], arr[j + 1]))
                    j++;
                if (!less(arr[i], arr[j])) break;
                exch(arr, i, j);
                i = j;
            }
        }

        private static void exch(int[] arr, int v1, int v2)
        {
            int tmp = arr[v1];
            arr[v1] = arr[v2];
            arr[v2] = tmp;
        }

        private static bool less(int j, int v)
        {
            if (j < v)
                return true;

            return false;
        }
    }
}
