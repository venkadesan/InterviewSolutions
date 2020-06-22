using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class PowerSet
    {

        //1. Recursive solution
        #region GetSubSets
        /// <summary>
        ///  Getting subsets of any List of integer
        /// </summary>
        /// <param name="set">array set</param>
        /// <param name="index">starting index</param>
        /// <returns></returns>
        public List<List<int>> GetSubSets(List<int> set, int index)
        {
            List<List<int>> allSubsets = new List<List<int>>();
            if (set.Count == index)
            {
                allSubsets.Add(new List<int>());
            }
            else
            {
                allSubsets = GetSubSets(set, index + 1);
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

        #endregion


        #region Combinatorics solution
        /// <summary>
        ///  Get subs sets using bit shifting
        /// </summary>
        /// <param name="sets"></param>
        /// <returns></returns>
        public List<List<int>> GetSubSets2(List<int> sets)
        {
            List<List<int>> allSubsets = new List<List<int>>();
            int max = 1 << sets.Count;
            for (int k = 0; k < max; k++)
            {
                List<int> subset = converIntToSet(k, sets);
                allSubsets.Add(subset);
            }
            return allSubsets;
        }
        private List<int> converIntToSet(int x, List<int> set)
        {
            List<int> subSet = new List<int>();
            int index = 0;
            for (int k = x; k > 0; k >>= 1)
            {
                if ((k & 1) == 1)
                {
                    subSet.Add(set[index]);
                }
                index++;
            }
            return subSet;
        }
        #endregion

    }
}
