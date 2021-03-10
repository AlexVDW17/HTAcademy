using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class Binary
    {
        /// <summary>
        ///     Binary Search is not a sorting algorithm, but has been included because it is often taught concurrently
        ///     Effectively, you recursively call a search on halves of a sorted list until you hit the desired key
        ///     eg. in the list 1 2 3 4 5 6 7 8 9 10, searching for the number 3 would result in
        ///     checking the center: 5, followed by cutting off the half over the key: 1 2 3 4 are left
        ///     now we check the center again: 2. this is too low, so we cut off the lower half, leaving 3 4
        ///     we check the "center" (really the end) and get 3!
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="key"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static int Search(int[] arr, int key, int min, int max)
        {
            int middle = (min + max) / 2;
            if(min >= max)
            {
                /// here we use -1 as the error result if the key is not in the list
                /// check out https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator 
                /// for information about the turnary ? operator
                return arr[min] == key ? min : -1;
            }

            if (arr[middle] == key)
            {
                return middle;
            }

            else if (key < arr[middle])
            {
                return Search(arr, key, min, middle -1);
            }

            return Search(arr, key, middle + 1, max);

        }
    }
}
