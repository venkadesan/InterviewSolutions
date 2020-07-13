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
            // Two line intersection
            TwoLineIntersection();
            // Factorial Zeroes
            FactorialZeroes();
          
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

        private static void TwoLineIntersection()
        {
            LineIntersection intersectUtil = new LineIntersection();

            Point start1 = new Point(1, 4);
            Point end1 = new Point(4, 5);
            Point start2 = new Point(1, 5);
            Point end2 = new Point(4, 4);
            var interesectPoint = intersectUtil.Intersection(start1, end1, start2, end2);
            if (interesectPoint != null)
            {
                Console.WriteLine($"is two line intersect ? :  {interesectPoint.x} {interesectPoint.y}");
            }

        }

        private static void FactorialZeroes()
        {
            FactorialZeros factZeroes = new FactorialZeros();
            int number = 19;
            Console.WriteLine($" {factZeroes.countFactZeroes(number)}");

        }
    }
}
