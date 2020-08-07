using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class SubSort
    {

        #region public methods
        public void findUnsortedSequence(int[] array)
        {

        }
        #endregion


        #region private methods
        private int findEndOfLeftSequence(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[i + 1]) return i + 1;
            }
            return 0;
        }

        private int findStartOfRightSequence(int[] array)
        {
            for (int i = array.Length - 2; i >= 0; i++)
            {
                if (array[i] > array[i + 1]) return i + 1;
            }
            return 0;
        }
        #endregion



    }
}
