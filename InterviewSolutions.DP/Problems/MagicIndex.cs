using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class MagicIndex
    {
        // Algorithm to search the array where elements are not distinct.

        #region MagicFast
        public int MagicFast(int[] array)
        {
            return MagicFast(array, 0, array.Length - 1);
        }
        #endregion

        #region Magic Fast
        private int MagicFast(int[] array, int start, int end)
        {
            if (end < start) return -1;
            int midIndex = (start + end) / 2;
            int midValue = array[midIndex];
            if (midIndex == midValue)
            {
                return midIndex;
            }
            int leftIndex = Math.Min(midIndex - 1, midValue);
            int left = MagicFast(array, start, leftIndex);
            if (left >= 0)
            {
                return left;
            }
            int rightIndex = Math.Max(midIndex + 1, midValue);
            int right = MagicFast(array, rightIndex, end);
            return right;
        }
        #endregion

    }
}
