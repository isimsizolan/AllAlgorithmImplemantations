using System;
using System.Collections.Generic;
using System.Text;

namespace AllAlgorithmImplemantations.Sorting
{
    public static class QuickSortExtension
    {
        public static int[] QuickSort(this int[] arr)
        {
            sort(arr, 0, arr.Length-1);
            return arr;
        }

        private static void sort(int[] arr, int low, int high )
        {
            if (high <= low)
                return;
            int pivotindex = partition(arr, low, high);
            sort(arr, low, pivotindex-1);
            sort(arr, pivotindex+1, high);
        }
        private static int partition(int[] arr,int low, int high)
        {

            int i = low;
            int j = high + 1;
            int pivot = arr[low];

            while (true)
            {
                while (arr[++i] < pivot)
                {
                    if (i == high)
                        break;
                }   
                while (pivot < arr[--j])
                {
                    if (j == low)
                        break;
                }
                if (i >= j)
                    break;
                exhange(arr, i, j);
            }

            
            exhange(arr, low, j);
            return j;
        }

        private static void exhange(int[] arr, int i, int j)
        {
            int tmp = arr[j];
            arr[j] = arr[i];
            arr[i] = tmp;
        }
    }
}
