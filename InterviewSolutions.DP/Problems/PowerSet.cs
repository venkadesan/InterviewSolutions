using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class PowerSet
    {
        //1. Recursive solution
        public List<List<int>> getSubSets(List<int> set, int index)
        {
            List<List<int>> allSubsets = new List<List<int>>();
            if (set.Count == index)
            {
                allSubsets.Add(new List<int>());
            }
            else
            {
                allSubsets = getSubSets(set, index + 1);
                int item = set[index];
                List<List<int>> moreSubsets = new List<List<int>>();
                foreach (List<int> subset in allSubsets)
                {
                    List<int> newSubsets = new List<int>();
                    newSubsets.AddRange(subset);
                    newSubsets.Add(item);
                    moreSubsets.Add(newSubsets);
                }
                allSubsets.AddRange(moreSubsets);
            }
            return allSubsets;

        }

    }
}
