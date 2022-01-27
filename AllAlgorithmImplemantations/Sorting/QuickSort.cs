using System;
using System.Collections.Generic;
using System.Text;

namespace AllAlgorithmImplemantations.Sorting
{
    public static class QuickSortExtension
    {
        public static void QuickSort(this int[] arr)
        {
            sort(arr, 0, arr.Length-1);
        }

        private static void sort(int[] arr, int low, int high )
        {
            //TODO: add control to return if array is sorted (asc or dsc)

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

            do
            {
                while (arr[++i] < pivot && i <= high);
                while (pivot < arr[--j] && j >= low);
                if(j>=i)
                    exhange(arr, i, j);
            } while (!(j < i));

            exhange(arr, j, low);
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
