using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class LettersAndNumbers
    {
        public char[] FindLongestSubArray(char[] array)
        {
            int[] deltas = ComputeDeltaArray(array);
            char[] deltas1 = new char[array.Length];
            return deltas1;
        }


        private int[] ComputeDeltaArray(char[] array)
        {
            int[] deltas = new int[array.Length];
            int delta = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsLetter(array[i]))
                {
                    delta++;
                }
                else if (char.IsDigit(array[i]))
                {
                    delta--;
                }
                deltas[i] = delta;
            }
            return deltas;
        }

        private int[] FindLogestSubArray(int[] array)
        {
            int[] max = new int[2];
            return max; 
        }


    }
}
