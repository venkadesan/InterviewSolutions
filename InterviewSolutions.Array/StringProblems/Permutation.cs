using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Array.StringProblems
{
    public class Permutation
    {
        public bool IsPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            int[] characters = new int[128];
            for (int i = 0; i < s1.Length; i++)
            {
                characters[s1[i]]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                characters[s2[i]]--;
                if (characters[s2[i]] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
