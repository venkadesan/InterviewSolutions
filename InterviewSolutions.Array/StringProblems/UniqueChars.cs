using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Array.StringProblems
{
    public class UniqueChars
    {

        public bool isUniqueChars(string str)
        {
            if (str.Length > 128) return false;
            bool[] char_set = new bool[128];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }
            return true;
        }

        public bool isUniqueChars2(string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }

            return true;
        }
    }
}
