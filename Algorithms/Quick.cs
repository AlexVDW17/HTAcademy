using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    public class Quick
    {
        /// <summary>
        ///     Partition is used to place all the numbers less than the pivot on one side of the array 
        ///     and all the numbers greater than the pivot on the other. We keep track of the split between these two "subarrays"
        ///     using lowIndex.  At the end, our pivot, which by definition is in the middle of the two lists
        ///     is inserted into the middle of the list
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>

        public static int Partition(int[] arr, int low, int high)
        {
            /// https://exceptionnotfound.net/quick-sort-csharp-the-sorting-algorithm-family-reunion/
            /// is a good source for reading more about quicksort
            int pivot = arr[high];
            int lowIndex = low - 1;
            for (int i = low; i < high; i++)
            {
                if (arr[i] <= pivot)
                {
                    lowIndex++;
                    int innerTemp = arr[lowIndex];
                    arr[lowIndex] = arr[i];
                    arr[i] = innerTemp;
                }
            }
            int outerTemp = arr[lowIndex + 1];
            arr[lowIndex + 1] = arr[high];
            arr[high] = outerTemp;

            return lowIndex + 1;
        }


        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionResult = Partition(arr, low, high);
                /// we use -1 and +1 because arr[partitionResult] is already in the right location
                Sort(arr, low, partitionResult - 1);
                Sort(arr, partitionResult + 1, high);
            }
        }
    }
}
