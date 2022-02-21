using System;
using System.Collections.Generic;
using System.Text;

namespace AllAlgorithmImplemantations.Searching
{
    public static class BinarySearchExtention
    {
        public static int BinarySearch(this int[] arr, int x)
        {

            int low = 0;
            int high = arr.Length-1;

            while (low <= high)
            {
                int mid =  (low+high)/2;
                if (arr[mid] == x)
                    return mid;
                else if (arr[mid] < x)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
    }
}
