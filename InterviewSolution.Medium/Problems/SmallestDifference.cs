using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class SmallestDifference
    {
        public int findSmallestDifference(int[] array1, int[] array2)
        {
            // Sorting arrays
            Array.Sort(array1);
            Array.Sort(array2);
            int diff = int.MaxValue;
            int a = 0;
            int b = 0;
            while (a < array1.Length && b < array2.Length)
            {
                if (Math.Abs(array1[a] - array2[b]) < diff)
                {
                    diff = Math.Abs(array1[a] - array2[b]);
                }
                // Move smaller value.
                if (array1[a] < array2[b])
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            return diff;
        }
    }
}
