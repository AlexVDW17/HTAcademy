using SortingAlgorithms.Algorithms;
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = getArr();
            Console.WriteLine("QuickSort Example");
            Quick.Sort(arr, 0, 3);
            Program.PrintArr(arr);
            Console.WriteLine();

            arr = getArr();
            Console.WriteLine("Insertion Sort Example");
            Insertion.Sort(arr);
            Program.PrintArr(arr);
            Console.WriteLine();

            arr = getArr();
            Console.WriteLine("Bubble Sort Example");
            Bubble.Sort(arr);
            Program.PrintArr(arr);
            Console.WriteLine();

            arr = getArr();
            Console.WriteLine("Selection Sort Example");
            Selection.Sort(arr); 
            Program.PrintArr(arr);
            Console.WriteLine();

            Console.WriteLine("Binary Search Example: search for 30 in the sorted list");
            Console.WriteLine("Position: " + Binary.Search(arr, 30, 0, 3));
            Console.WriteLine();

            Console.WriteLine("Linear Search Example: search for 30 in a random list");
            Console.WriteLine("Position: " + Binary.Search(getArr(), 30, 0, 3));
            Console.WriteLine();

        }

        /// <summary>
        ///     print a 4 digit array
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintArr(int[] arr)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", arr[0], arr[1], arr[2], arr[3]);
        }

        private static int[] getArr()
        {
            return new int[] { 40, 20, 10, 30 };
        }

        /// <summary>
        ///     swaps a value with the one that directly follows it.
        ///     used in several of the sorting algorithms
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        public static void Swap(int[] arr, int firstIndex, int secondIndex)
        {
            int temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
    }
}
