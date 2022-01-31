using System;
using System.Collections.Generic;
using System.Text;

namespace AllAlgorithmImplemantations.Sorting
{
    public class BubbleSort : ISort
    {

        public int[] Sort(int[] arr)
        {

            int len = arr.Length;

            for (int i = 0; i < len - 1; i++)
            {
                bool isSortingCompleted = true;
                for (int j = 0; j < len - i -1; j++)
                {

                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        isSortingCompleted = false;
                    }
                }

                if (isSortingCompleted)
                {
                    break;
                }
            }

            return arr;
        }
    }
}
