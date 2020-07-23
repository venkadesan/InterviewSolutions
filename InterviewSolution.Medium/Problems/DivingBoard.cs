using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class DivingBoard
    {
        public HashSet<int> allLengths(int k, int shorter,int loger)
        {
            HashSet<int> lengths = new HashSet<int>();
            for (int nshorter = 0; nshorter <= k; nshorter++)
            {
                int nLonger = k - nshorter;
                int length = nshorter * nshorter + nLonger * nLonger;
                lengths.Add(length);
            }
            return lengths;
        }
    }
}
