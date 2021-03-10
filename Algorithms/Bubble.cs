using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class Bubble
    {
        /// <summary>
        ///     possibly the simplest sorting algorithm, bubble sort simply takes each number
        ///     and checks if the following number is less than itself. 
        ///     if so, they change positions. Rinse and repeat!
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length -1 ; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        Program.Swap(arr, j, j + 1);
                    }
                }
            }
        }
        
    }
}
