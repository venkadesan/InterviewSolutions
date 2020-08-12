using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class PatternMatching
    {

        #region public methods
        public bool doesMatch(string pattern, string value)
        {
            if (pattern.Length == 0)
                return value.Length == 0;

            char mainChar = pattern[0];
            char altChar = mainChar == 'a' ? 'b' : 'a';
            int size = value.Length;

            int countOfMain = CountOf(pattern, mainChar);
            int countOfAlt = pattern.Length - countOfMain;
            int firstAlt = pattern.IndexOf(altChar);
            int maxMainSize = size / countOfMain;

            for (int mainSize = 0; mainSize <= maxMainSize; mainSize++)
            {
                int remainingLength = size - mainSize * countOfMain;
                if (countOfAlt == 0 || remainingLength % countOfAlt == 0)
                {
                    int altIndex = firstAlt * mainSize;
                    int altSize = countOfAlt == 0 ? 0 : remainingLength / countOfAlt;
                    if (matches(pattern, value, mainSize, altSize, altIndex))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion


        #region private methods
        private int CountOf(string pattern, char c)
        {
            int count = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == c)
                {
                    count++;
                }
            }
            return count;
        }

        private bool isEqual(string s1, int offSet1, int offSet2, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (s1[offSet1 + i] != s1[offSet2 + i])
                {
                    return false;
                }
            }
            return true;
        }

        private bool matches(string pattern, string value, int mainSize, int altSize, int firstAlt)
        {
            int stringIndex = mainSize;
            for (int i = 1; i < pattern.Length; i++)
            {
                int size = pattern[i] == pattern[0] ? mainSize : altSize;
                int offSet = pattern[i] == pattern[0] ? 0 : firstAlt;
                if (!isEqual(value, offSet, stringIndex, size))
                {
                    return false;
                }
                stringIndex += size;
            }
            return true;
        }
        #endregion

    }
}
