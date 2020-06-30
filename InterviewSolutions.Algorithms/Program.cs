using System;
using InterviewSolutions.Algorithms.Sorting;
using InterviewSolutions.Algorithms.Search;
namespace InterviewSolutions.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sorting Algorithms
            SortingAlgorithms();
            // Searching in Rotated Array
            RotatedArray();
        }


        private static void SortingAlgorithms()
        {
            // Sorting Algorithms
            int[] a = new int[] { 5, 1, 7, 2, 6, 4, 8, 3 };

            QuickSort qs = new QuickSort();
            MergeSort ms = new MergeSort();

            ms.Sort(a, 0, a.Length - 1);
            int[] result = qs.SortArray(a, 0, a.Length - 1);

            //int[] a = new int[] { 1, 2, 4, 3, 4, 5 };
            //int[] rotate = new int[] { 0, 2, 3 };
            //int[] results = getMaxElementIndices(a, rotate);
        }

        private static void RotatedArray()
        {
            RotatedArray array = new RotatedArray();
            int[] a = new int[] { 5, 6, 7, 8, 1, 2, 3 };
            int leftIndex = 0;
            int rightIndex = a.Length - 1;
            int numberToFind = 2;
            Console.WriteLine($"Searching in rotated array {array.search(a, leftIndex, rightIndex, numberToFind)}");

        }
    }
}
