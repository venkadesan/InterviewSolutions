using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class Operations
    {

        #region public methods

        #region subtraction
        public int minus(int a, int b)
        {
            return a + negate(b);
        }
        #endregion

        #region multiplication
        public int multiply(int a, int b)
        {
            if (a < b)
            {
                return multiply(b, a);
            }
            int sum = 0;

            for (int i = abs(b); i > 0; i = minus(i, 1))
            {
                sum += a;
            }

            if (b < 0)
            {
                sum = negate(sum);
            }

            return sum;
        }
        #endregion

        #region Division
        public int divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("ERROR");
            }
            int absa = abs(a);
            int absb = abs(b);
            int product = 0;
            int x = 0;
            while (product + absb <= absa)
            {
                product += absb;
                x++;
            }

            if ((a < 0 && b < 0) || (a > 0 && b > 0))
            {
                return x;
            }
            else
            {
                return negate(x);
            }
        }
        #endregion
        #endregion


        #region private methods
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



        private int abs(int a)
        {
            if (a < 0)
            {
                return negate(a);
            }
            return a;
        }

        #endregion

    }
}
