using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Array.StringProblems
{
    public class Rotation
    {
        public bool IsRotation(string s1, string s2)
        {
            int len = s1.Length;
            if (len == s2.Length && len > 0)
            {
                string s1s1 = s1 + s2;
                return isSubstring(s1s1, s2);
            }

            return false;
        }

        private bool isSubstring(string s1, string s2)
        {
            if (!string.IsNullOrWhiteSpace(s1) && !string.IsNullOrWhiteSpace(s2))
            {
                return s1.Contains(s2);
            }
            return false;
        }
    }
}
