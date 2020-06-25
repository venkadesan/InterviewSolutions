using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class Parens
    {
        #region private variables
        private readonly char LEFT_PAREN = '(';
        private readonly char RIGHT_PAREN = ')';
        #endregion

        #region Generate Parens
        public List<string> GeneateParen(int count)
        {
            char[] str = new char[count * 2];
            List<string> result = new List<string>();
            addParen(result, count, count, str, 0);
            return result;
        }
        #endregion


        private void addParen(List<string> list, int leftRem, int rightRem, char[] str, int index)
        {
            if (leftRem < 0 || rightRem < leftRem) return;

            if (leftRem == 0 && rightRem == 0)
            {
                list.Add(new string(str));
            }
            else
            {
                str[index] = LEFT_PAREN;
                addParen(list, leftRem - 1, rightRem, str, index + 1);

                str[index] = RIGHT_PAREN;
                addParen(list, leftRem, rightRem - 1, str, index + 1);
            }
        }
    }
}
