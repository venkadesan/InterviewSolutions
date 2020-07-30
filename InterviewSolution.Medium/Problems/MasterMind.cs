using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class MasterMind
    {

        #region private variables
        int MAX_COLORS = 4;
        #endregion


        #region public methods
        public Result estimate(string guess, string solution)
        {
            var res = new Result();
            if (guess.Length != solution.Length)
            {
                return null;
            }

            int[] frequencies = new int[MAX_COLORS];
            var guessChars = guess.ToCharArray();
            var solutionChars = solution.ToCharArray();

            for (int i = 0; i < guess.Length; i++)
            {
                if (guessChars[i].Equals(solutionChars[i]))
                {
                    res.hits++;
                }
                else
                {
                    int code = Code(solutionChars[i]);
                    frequencies[code]++;
                }
            }

            // Pseduo Code hits
            for (int i = 0; i < guess.Length; i++)
            {
                int code = Code(guess[i]);
                if (code >= 0 && frequencies[code] > 0 && !guessChars[i].Equals(solutionChars[i]))
                {
                    res.pseduoHits++;
                    frequencies[code]--;
                }
            }

            return res;
        }
        #endregion

        #region private methods
        private int Code(char c)
        {
            switch (c)
            {
                case 'B':
                    return 0;
                case 'G':
                    return 1;
                case 'R':
                    return 2;
                case 'Y':
                    return 3;
                default:
                    return -1;
            }
        }
        #endregion


    }

    #region Result Class
    public class Result
    {
        public int hits = 0;
        public int pseduoHits = 0;

        public override string ToString()
        {
            return $"{hits}, {pseduoHits}";
        }


    }
    #endregion

}
