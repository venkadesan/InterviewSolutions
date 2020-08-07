using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
   public class ContiguousSequence
    {
        public int GetMaxSum(int[] array)
        {
            int maxSum = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
                else if (sum < 0)
                {
                    sum = 0;
                }
            }
            return maxSum;
        }
    }
}
