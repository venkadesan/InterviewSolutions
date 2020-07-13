using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class WordFrequencies
    {
        public int GetFrequency(string[] book, string word)
        {
            int count = 0;
            word = word.Trim().ToLower();
            foreach (string bWord in book)
            {
                if (bWord.ToLower().Equals(word))
                {
                    count++;
                }
            }
            return count;
        }

        public int GetFrequency(Dictionary<string, int> wordFeq, string word)
        {
            if (wordFeq == null || wordFeq.Count == 0) return -1;
            word = word.Trim().ToLower();
            if (wordFeq.ContainsKey(word))
            {
                return wordFeq[word];
            }
            return 0;
        }

        public Dictionary<string, int> setupDictionary(string[] book,string word)
        {
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();
            if (book != null && book.Length > 0)
            {
                word = word.Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(word))
                {
                    foreach (string strWord in book)
                    {
                        if (word.Equals(strWord))
                        {
                            if(!wordFreq.ContainsKey(word))
                            {
                                wordFreq.Add(word, 0);
                            }
                            wordFreq[word]++;
                        }
                    }

                }
            }
            return wordFreq;
        }
    }
}
