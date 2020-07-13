using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    /// <summary>
    ///  This class counts # of trailing zeros in the in n Factorial.
    /// </summary>
    public class FactorialZeros
    {

        public int countFactZeroes(int num)
        {
            int count = 0;
            if (num < 0)
            {
                return -1;
            }
            for (int i = 5; num / i>0; i *= 5)
            {
                count += num / i;
            }

            return count;
        }
    }
}
