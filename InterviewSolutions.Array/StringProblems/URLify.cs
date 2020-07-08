using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Array.StringProblems
{
    public class URLify
    {
        public void replaceSpaces(char[] str, int length)
        {
            int spaceCounter = 0;
            int index = 0;

            for (int i = 0; i < length; i++)
            {
                if (str[i] == ' ')
                {
                    spaceCounter++;
                }
            }

            index = length + spaceCounter * 2;
            if (length < str.Length) str[length] = '\0';

            for (int i = length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }
        }
    }
}
