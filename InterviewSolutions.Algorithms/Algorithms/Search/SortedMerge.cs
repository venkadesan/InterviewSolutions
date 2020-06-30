using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Algorithms.Search
{
    public class SortedMerge
    {
        public void merge(int[] a, int[] b, int lastIndexA, int lastIndexB)
        {
            int indexA = lastIndexA - 1;
            int indexB = lastIndexB - 1;
            int indexMerged = lastIndexB + lastIndexA - 1;

            while (indexB >= 0)
            {
                if (indexA >= 0 && a[indexA] > b[indexB])
                {
                    a[indexMerged] = a[indexA];
                    indexA--;
                }
                else {
                    a[indexMerged] = b[indexB];
                    indexB--;
                }
                indexMerged--;
            }
        }
    }
}
