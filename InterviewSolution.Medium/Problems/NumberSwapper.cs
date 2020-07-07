using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class NumberSwapper
    {
        public void SwapNumber(int a, int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }
    }
}
