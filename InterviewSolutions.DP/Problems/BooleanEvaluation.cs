using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class BooleanEvaluation
    {
        public int countEval(string s, bool result, Dictionary<string, int> memo)
        {
            if (s.Length == 0) return 0;
            if (s.Length == 1) return stringToBool(s) == result ? 1 : 0;

            if (memo.ContainsKey(result + s)) return memo[result + s];

            int ways = 0;
            for (int i = 1; i < s.Length; i += 2)
            {
                char c = s[i];
                string left = s.Substring(0, i);
                string right = s.Substring(i + 1);
                int leftTrue = countEval(left, true, memo);
                int leftFalse = countEval(left, false, memo);
                int rightTrue = countEval(right, true, memo);
                int rightFalse = countEval(right, false, memo);
                int total = (leftTrue + leftFalse) * (rightTrue + rightFalse);
                int totalTrue = 0;
                if (c == '^')
                {
                    totalTrue = leftTrue * rightFalse + leftFalse * rightTrue;
                }
                else if (c == '&')
                {
                    totalTrue = leftTrue * rightTrue;
                }
                else if (c == '|')
                {
                    totalTrue = (leftTrue * rightTrue) +
                                (leftFalse * rightTrue) +
                                (leftTrue * rightFalse);
                }
                int subWays = result ? totalTrue : total - totalTrue;
                ways += subWays;

            }
            memo[result + s] = ways;
            return ways;
        }

        private bool stringToBool(String c)
        {
            return c.Equals("1") ? true : false;
        }
    }
}
