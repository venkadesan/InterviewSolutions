using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class Coins
    {
        public int MakeChange(int n)
        {
            int[] denoms = { 25, 10, 5, 1 };
            int[,] map = new int[n + 1, denoms.Length];
            return makeChange(n, denoms, 0, map);

        }

        private int makeChange(int amount, int[] denmos, int index, int[,] map)
        {
            if (map[amount, index] > 0)
            {
                return map[amount, index];
            }

            if (index >= denmos.Length - 1) return 1;

            int denomAmount = denmos[index];
            int ways = 0;

            for (int i = 0; i * denomAmount <= amount; i++)
            {
                int amountRemaining = amount - i * denomAmount;
                ways += makeChange(amountRemaining, denmos, index + 1, map);
            }
            map[amount, index] = ways;
            return ways;

        }
    }
}
