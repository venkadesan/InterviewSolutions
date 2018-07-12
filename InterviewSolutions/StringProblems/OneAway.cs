using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions
{
    class OneAway
    {
        public Boolean oneEditAway(string first, string second)
        {
            if (first.Length == second.Length)
                return oneEditReplace(first, second);
            else if (first.Length + 1 == second.Length)
                return oneEditInsert(first, second);
            else if (first.Length - 1 == second.Length)
                return oneEditInsert(second, first);
            return false;

        }

        private Boolean oneEditReplace(string s1, string s2)
        {
            Boolean foundDifference = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (foundDifference) return false;
                    foundDifference = true;
                }
            }
            return true;
        }

        private Boolean oneEditInsert(string s1, string s2)
        {
            int index1 = 0;
            int index2 = 0;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else {
                    index1++;
                    index2++;
                }
            }
            return true;
        }


        public Boolean oneEditAwayVersion1(string first, string second)
        {
            if ((first.Length - second.Length) > 1) return false;

            string s1 = first.Length < second.Length ? first : second;
            string s2 = first.Length < second.Length ? second : first;

            int index1 = 0;
            int index2 = 0;
            Boolean foundDifference = false;
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (foundDifference) return false;
                    foundDifference = true;
                    if (s1.Length == s2.Length) index1++;

                }
                else {
                    index1++;
                }
                index2++;
            }
            return true;
        }
    }
}
