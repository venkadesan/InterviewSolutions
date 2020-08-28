using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class LettersAndNumbers
    {

        #region public methods
        public char[] FindLongestSubArray(char[] array)
        {
            //computing deltas between count of numbers and  count of letters.
            int[] deltas = ComputeDeltaArray(array);
            //Find pair in deltas and matching sub array.
            int[] match = FindLogestMatch(deltas);
            //returning sub array.
            return ExtractSubArray(array, match[0] + 1, match[1]);
        }
        #endregion




        #region private methods
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

        private int[] FindLogestMatch(int[] deltas)
        {
            int[] max = new int[2];
            var map = new Dictionary<int, int>();
            map.Add(0, -1);
            for (int i = 0; i < deltas.Length; i++)
            {
                if (!map.ContainsKey(deltas[i]))
                {
                    map.Add(deltas[i], i);
                }
                else
                {
                    int match = map[deltas[i]];
                    int distance = i - match;
                    int longest = max[1] - max[0];
                    if (distance > longest)
                    {
                        max[1] = i;
                        max[0] = match;
                    }
                }
            }
            return max;
        }

        private char[] ExtractSubArray(char[] array, int start, int end)
        {
            char[] subArray = new char[end - start + 1];
            for (int i = start; i <= end; i++)
            {
                subArray[i - start] = array[i];
            }
            return subArray;
        }
        #endregion



    }
}
