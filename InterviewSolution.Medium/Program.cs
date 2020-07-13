using System;
using InterviewSolution.Medium.Problems;

namespace InterviewSolution.Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number swapper
            NumberSwap();
            // Word Frequencies
            WordFrequencies();
        }

        private static void NumberSwap()
        {
            NumberSwapper swapper = new NumberSwapper();
            int a = 9;
            int b = 5;
            swapper.SwapNumber(a, b);
        }

        private static void WordFrequencies()
        {
            WordFrequencies freq = new WordFrequencies();
            string[] book = new string[] { "test", "test2", "test" };
            var word = "test";

            // Solution 1
            Console.WriteLine($"word frequencies solution1 {freq.GetFrequency(book, word)}");

            // solution 2
            var wordfreq = freq.setupDictionary(book, word);
            Console.WriteLine($"word Frequencies Solution 2  {freq.GetFrequency(wordfreq, word)}");
        }
    }
}
