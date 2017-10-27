using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions
{
    public class Palindrome
    {
        public  Boolean IsPermutationOfPalindrome(List<string> lstOfPalindromes)
        {
            try
            {
                if (lstOfPalindromes != null && lstOfPalindromes.Count > 0)
                {
                    foreach(string pal in lstOfPalindromes)
                    {
                        int[] table = buildCharFrequencyTable(pal);
                        return checkMaxOneOdd(table);  
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        /// <summary>
        /// Checks for more than one odd number
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        private static Boolean checkMaxOneOdd(int[] table)
        {
            Boolean foundOdd = false;
            for (int count = 0; count < table.Length; count++)
            {
                if (table[count] % 2 == 1)
                {
                    if(foundOdd)
                    {
                        return false;
                    }
                    foundOdd = true;
                }
            }
            return true;
        }
        /// <summary>
        /// Maps each character to a Number.  a --> 0, b-->1, C -->2, etc.,
        /// This is case insensitive. Non- letter characters map to -1.
        /// </summary>
        /// <param name="c">character</param>
        /// <returns></returns>
        private int getCharNumbers(char c)
        {
            int a = Convert.ToInt32('a');
            int z = Convert.ToInt32('z');
            int val = Convert.ToInt32(c);
            if (a <= val && val <= z)
            {
                return (val - a);
            }
            return -1;
        }

        private int[] buildCharFrequencyTable(string phrase)
        {
            int[] table = new int[Convert.ToInt32('z') - Convert.ToInt32('a') + 1];
            foreach (char c in phrase.ToCharArray())
            {
                int x = getCharNumbers(c);
                if(x!=-1)
                {
                    table[x]++;
                }
            }
            return table;
        }

    }
}
