using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class Insertion
    {
        /// <summary>
        ///     insertion sort is one of the simpler sorts, and also one of the slowest. 
        ///     It takes one number at a time and places it at the correct position
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            /// iterate over the elements of the array
            for (int i = 0; i < arr.Length; i++)
            {
                /// get the value we care about
                int val = arr[i];

                int j = i - 1;
                /// if the number directly preceding val is greater than val, we shift it up a position
                while (j >= 0 && arr[j] > val)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                /// once this process completes we place val in the last vacated position
                arr[j + 1] = val;
            }
        }
    }
}
