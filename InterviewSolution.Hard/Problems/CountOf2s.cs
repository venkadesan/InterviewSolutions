using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class CountOf2s
    {

        #region public methods

        public int Count2sInRange(int number)
        {
            int count = 0;
            int len = Convert.ToString(number).Length;
            for (int digit = 0; digit < len; digit++)
            {
                count += Count2sInRangeAtDigit(number, digit);
            }
            return count;
        }
        #endregion

        #region private methods
        private int Count2sInRangeAtDigit(int num, int d)
        {
            int powerOf10 = (int)Math.Pow(10, d);
            int nextPowerOf10 = powerOf10 * 10;
            int right = num % powerOf10;

            int roundDown = num - num % nextPowerOf10;
            int roundUp = roundDown + nextPowerOf10;

            int digit = (num / powerOf10) % 10;
            if (digit < 2)
            {
                return roundDown / 10;
            }
            else if (digit == 2)
            {
                return roundDown / 10 + right + 1;

            }
            else
            {
                return roundUp / 10;
            }

        }
        #endregion

    }
}
