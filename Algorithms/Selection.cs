using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class Selection
    {

        /// <summary>
        ///     selection sort works by breaking the array into an unsorted subarray and a sorted subarray. 
        ///     the lowest number in the unsorted subarray is taken and placed at the end of the sorted subarray until the unsorted is empty
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int indexOfLowest = i;
                int lowest = int.MaxValue;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < lowest)
                    {
                        indexOfLowest = j;
                        lowest = arr[j];
                    }
                }

                Program.Swap(arr, i, indexOfLowest);
            }
        }
    }
}
