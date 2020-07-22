﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class Operations
    {

        #region subtraction
        public int minus(int a, int b)
        {
            return a + negate(b);
        }
        #endregion


        #region multiplication
        public int multiply(int a, int b)
        {
            return 0;
        }
        #endregion


        private int negate(int a)
        {
            int neg = 0;
            int newSign = a < 0 ? 0 : -1;
            int delta = newSign;
            while (a != 0)
            {
                bool diffSigns = (a + delta > 0) != (a > 0);
                if (a + delta != 0 && diffSigns)
                {
                    delta = newSign;
                }
                neg += delta;
                a += delta;
                delta += delta;
            }

            return neg;
        }
    }
}
