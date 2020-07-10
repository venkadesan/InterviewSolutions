using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
   public class AddWithoutPlus
    {

        public int Add(int a, int b)
        {
            while (b != 0)
            {
                int sum = a ^ b;
                int carry = (a & b) << 1;
                a = sum;
                b = carry;
            }

            return a;
        }
    }

}
