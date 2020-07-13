using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class NumberMax
    {
        public int GetMaxNumber(int num1, int num2)
        {

            int diff = num1 - num2;
            int sa = sign(num1);
            int sb = sign(num2);
            int sc = sign(diff);

            int use_sign_of_num1 = sa ^ sb;
            int use_sign_of_diff = flip(sa ^ sb);
            int k = use_sign_of_num1 * sa + use_sign_of_diff * sc;
            int q = flip(k);

            return num1 * k + num2 * q;
            //return num1;
        }

        // REturns 1 if a is positive and 0 if a is negative.
        private int sign(int a)
        {
            return flip((a >> 31) & 0x1);
        }

        
        private int flip(int bit)
        {
            return 1 ^ bit;

        }


    }
}
