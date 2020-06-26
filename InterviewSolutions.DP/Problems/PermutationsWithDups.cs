using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class PermutationsWithDups
    {

        #region GetPerms
        public List<string> GetPerms(string str)
        {
            List<string> result = new List<string>();
            Dictionary<char, int> map = BuildFreqTable(str);
            printPerms(map, "", str.Length, result);
            return result;
        }
        #endregion



        private void printPerms(Dictionary<char, int> map, string prefix, int remaining, List<string> result)
        {
            if (remaining == 0)
            {
                result.Add(prefix);
                return;
            }
            var keys = map.Keys;

            for (int i = 0; i < keys.Count; i++)
            {
                var key = keys.ElementAt(i);
                int count = map[key];
                if (count > 0)
                {
                    map[key] = count - 1;
                    printPerms(map, prefix + key, remaining - 1, result);
                    map[key] = count;
                }
            }

            //initialize a dictionary with keys and values.
         
        }
        Dictionary<char, int> BuildFreqTable(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s.ToCharArray())
            {
                if (!map.ContainsKey(c))
                {
                    map.Add(c, 0);
                }
                map[c] = map[c] + 1;
            }
            return map;
        }



    }
}

