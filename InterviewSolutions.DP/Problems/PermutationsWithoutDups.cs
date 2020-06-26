using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class PermutationsWithoutDups
    {

        #region "Get Perms"
        public List<string> GetPerms(string str)
        {
            List<string> result = new List<string>();
            getPerms("", str, result);
            return result;
        }
        #endregion


        #region private method
        private void getPerms(string prefix, string remainder, List<string> result)
        {
            if (remainder.Length == 0) result.Add(prefix);

            int len = remainder.Length;

            for (int i = 0; i < len; i++)
            {
                string before = remainder.Substring(0, i);
                string after = remainder.Substring(i + 1);
                char c = remainder[i];
                getPerms(prefix + c, before + after, result);
            }
        }
        #endregion

    }
}
