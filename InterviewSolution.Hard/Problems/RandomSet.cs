using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class RandomSet
    {
        public int[] PickMInIteratively(int[] original, int m)
        {
            int[] subset = new int[m];
            for (int i = 0; i < m; i++)
            {
                subset[i] = original[i];
            }

            for (int i = 0; i < original.Length; i++)
            {
                int k = Rand(0, i);
                if (k < m)
                {
                    subset[k] = original[i];
                }
            }
            return subset;
        }

        private int Rand(int lower, int higher)
        {
            return lower + (int)(new Random().Next(0, 1) * (higher - lower) + 1);
        }
    }
}
