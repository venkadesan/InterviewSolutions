using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Algorithms.Search
{
    class PeakAndValley
    {
        public void SortValleyPeak(int[] array)
        {
            for (int i = 1; i < array.Length; i+=2)
            {
                int biggestIndex = MaxIndex(array, i - 1, i, i + 1);
                if (i != biggestIndex)
                {
                    swap(array, i, biggestIndex);
                }
            }

        }

        private int MaxIndex(int[] array, int a, int b, int c)
        {
            int len = array.Length;
            int aValue = a >= 0 && a < len ? array[a] : int.MinValue;
            int bValue = b >= 0 && b < len ? array[b] : int.MinValue;
            int cValue = c >= 0 && c < len ? array[c] : int.MinValue;

            int max = Math.Max(aValue, Math.Max(bValue, cValue));
            if (aValue == max) return a;
            else if (bValue == max) return b;
            else return c;
        }

        private void swap(int[] array, int index1,int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
