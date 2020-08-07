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
            int end_left = findEndOfLeftSequence(array);
            if (end_left >= array.Length - 1) return;

            int right_start = findStartOfRightSequence(array);
            // min and max
            int max_index = end_left;
            int min_index = right_start;

            for (int i = end_left + 1; i < right_start; i++)
            {
                if (array[i] < array[min_index]) min_index = i;
                if (array[i] > array[max_index]) max_index = i;
            }

            int left_index = ShrinkLeft(array, min_index, end_left);

            int right_index = ShrinkRight(array, max_index, right_start);

            Console.WriteLine($" {left_index} , { right_index}");

        }
        #endregion


        #region private methods
        private int findEndOfLeftSequence(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) return i + 1;
            }
            return 0;
        }

        private int findStartOfRightSequence(int[] array)
        {
            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] > array[i + 1]) return i + 1;
            }
            return 0;
        }

        private int ShrinkLeft(int[] array, int min_index, int start)
        {
            int comp = array[min_index];
            for (int i = start - 1; i >= 0; i--)
            {
                if (array[i] <= comp) return i + 1;
            }
            return 0;

        }

        private int ShrinkRight(int[] array, int max_index, int start)
        {
            int comp = array[max_index];
            for (int i = start; i < array.Length; i++)
            {
                if (array[i] >= comp) return i - 1;
            }

            return array.Length - 1;

        }
        #endregion



    }
}
