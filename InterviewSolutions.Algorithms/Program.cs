using System;
using System.Collections.Generic;
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
            // Sorted Merge
            SortedMerge();
            // Group Anagrams
            GroupAnagrams();
            // Sorted Search
            SortedSearch();
            // Sparse Search
            SparseSearch();
            // Finding duplicates
            //FindDuplicates();
            // Sorted Matrix search
            SortedMatrixSearch();
            // Rank Stream
            RankStream();

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

        private static void SortedMerge()
        {
            int[] a = new int[10];

            for (int i = 0; i < 5; i++)
            {
                a[i] = i;
            }

            int[] b = new int[5] { 6, 7, 8, 9, 10 };
            SortedMerge merge = new SortedMerge();
            merge.merge(a, b, 5, 5);
        }

        private static void GroupAnagrams()
        {
            GroupAnagrams anagrams = new GroupAnagrams();
            string[] array = new string[] { "acre", "race", "care" };
            anagrams.Sort(array);
            foreach (string str in array)
            {
                Console.WriteLine($"Group Anagrams {str}");
            }
        }


        private static void SortedSearch()
        {
            SortedSearch search = new SortedSearch();
            Listy list = new Listy(new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            var numToSearch = 3;
            Console.WriteLine($" Number to Search: {numToSearch}, {search.search(list, numToSearch)}");
        }


        private static void SparseSearch()
        {
            SparseSearch search = new SparseSearch();
            List<string> strings = new List<string>() { "at", "", "", "", "ball", "", "", "car", "", "", "dad", "", "" };
            string strToSearch = "ball";
            Console.WriteLine($"Index of searched string Index { search.Search(strings.ToArray(), strToSearch)}");
        }

        private static void FindDuplicates()
        {
            Duplicates dups = new Duplicates();
            int CAPACITY = 32000;
            int[] array = new int[CAPACITY];
            int DUPLICATE_RANGE = 10;
            int j = 0;
            for (int i = 0; i < CAPACITY; i++)
            {
                if (i < CAPACITY - DUPLICATE_RANGE)
                    array[i] = i;
                else
                {
                    array[i] = j;
                    j++;
                }
            }
            dups.checkDuplicates(array, CAPACITY);
        }


        private static void SortedMatrixSearch()
        {
            SortedMatrixSearch search = new SortedMatrixSearch();
            int[,] matrix = new int[,] { {15,20,40,85 },
                                          {20,35,80,90 },
                                          {30,55,95,105 },
                                          {40,80,100,120 } };
            int elementToSearch = 95;
            Console.WriteLine($"{search.findElement(matrix, elementToSearch)}");

            // coordinate.
            var coordinate = search.findElelement2(matrix, elementToSearch);
            Console.WriteLine($" row: {coordinate.row} col {coordinate.col}");

        }

        private static void RankStream()
        {
            var stream = new RankStream();
            var data = new int[] { 5,1,5,4,4,5,9,7,13,3 };
            int numberToFindRank = 4;
            Console.WriteLine($"Number :{numberToFindRank}  Rank: {stream.GetRank(data, numberToFindRank)}");
        }
    }
}
