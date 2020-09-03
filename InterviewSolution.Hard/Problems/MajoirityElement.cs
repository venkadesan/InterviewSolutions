using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class MajoirityElement
    {

        #region public methods

        #region FindMajorityElement
        public int FindMajorityElement(List<int> numbers)
        {
            if (numbers != null && numbers.Count > 0)
            {
                int candidate = GetCandidate(numbers);
                return validate(numbers, candidate) ? candidate : -1;
            }
            return 0;
        }
        #endregion
        #endregion


        #region private methods
        private int GetCandidate(List<int> numbers)
        {
            int majority = 0;
            if (numbers != null && numbers.Count > 0)
            {
                int count = 0;
                foreach (var num in numbers)
                {
                    if (count == 0)
                    {
                        majority = count;
                    }
                    if (num == majority)
                    {
                        count++;
                    }
                    else { count--; }
                }

            }
            return majority;
        }


        private bool validate(List<int> numbers, int majority)
        {
            int count = 0;
            foreach (var num in numbers)
            {
                if (num == majority)
                {
                    count++;
                }
            }
            return count > (numbers.Count / 2);
        }
        #endregion

    }
}
