using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class OldCellPhone
    {
        #region private variables
        public char[,] T9Letters { get; set; }
        #endregion

        public List<string> GetValidT9Words(string numbers, Dictionary<string, string> dicWords)
        {
            List<string> words = new List<string>();
            return words;
        }

        private Dictionary<string, List<string>> InitializeDictionary(string[] words)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            return dic;
        }

        private Dictionary<string, string> createLetterToNumberMap()
        {
            Dictionary<string, string> letterToNumberMap = new Dictionary<string, string>();
            for (int i = 0; i < T9Letters.Length; i++)
            {
                //char[] letters = T9Letters.;
            }
            return letterToNumberMap;
        }
    }
}
