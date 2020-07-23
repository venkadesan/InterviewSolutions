using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class DivingBoard
    {
        public HashSet<int> PossibleLengths(int MaxPlanksOfwoods, int shorterWoodLength,int longerWoodLength)
        {
            HashSet<int> lengths = new HashSet<int>();
            for (int nshorter = 0; nshorter <= MaxPlanksOfwoods; nshorter++)
            {
                int nLonger = MaxPlanksOfwoods - nshorter;
                int length = nshorter * nshorter + nLonger * nLonger;
                lengths.Add(length);
            }
            return lengths;
        }
    }
}
