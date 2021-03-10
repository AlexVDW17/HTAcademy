using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class Linear
    {
        /// <summary>
        ///     the most basic of all the search algorithms, a linear search checks every element until it finds what it wants
        ///     or reaches the end. It does not require a sorted list like binary search does, but it is very slow 
        ///     and ineficcient in comparison. 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int Search(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == key)
                {
                    return i;
                }
            }
            /// as with binary search, we use -1 to signify that the key is not in the list
            return -1;
        }
    }
}
