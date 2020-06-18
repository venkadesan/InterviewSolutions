using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP
{
    public class TripleSteps
    {

        #region CountWays
        public static int CountWays(int n)
        {
            int[] memo = new int[n + 1];
            initializeWithDefaultValue(memo);
            return CountWays(n, memo);
        }

        private static int CountWays(int n, int[] memo)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else if (memo[n] > -1)
            {
                return memo[n];
            }
            else
            {
                memo[n] = CountWays(n - 1, memo) + CountWays(n - 2, memo) + CountWays(n - 3, memo);
                return memo[n];
            }
        }
        #endregion

        #region initializeWithDefaultValue
        private static void initializeWithDefaultValue(int[] memo)
        {
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }
        }
        #endregion

    }
}
