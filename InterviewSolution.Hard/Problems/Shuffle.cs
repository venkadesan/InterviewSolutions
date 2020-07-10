using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class Shuffle
    {
        public void ShuffleArray(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int k = Rand(0, i);
                    int temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }
            }
        }

        private int Rand(int lower, int higher)
        {
            return lower + (int)(new Random().Next(0,1) * (higher - lower) + 1);
        }
    }
}
