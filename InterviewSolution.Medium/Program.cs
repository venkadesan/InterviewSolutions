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
            // Smallest difference in the array
            smallestDifference();
            // Get max number
            GetMaxNumber();
            // Convert Number to it's equal english words.
            EnglishInt();

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


        private static void smallestDifference()
        {
            SmallestDifference smallDiff = new SmallestDifference();
            int[] array1 = new int[] { 1, 3, 15, 11, 2 };
            int[] array2 = new int[] { 23, 127, 235, 19, 8 };
            Console.WriteLine($"The smallest difference in the array :  {smallDiff.findSmallestDifference(array1, array2)}");

        }

        private static void GetMaxNumber()
        {
            int number1 = 3;
            int number2 = 10;
            NumberMax max = new NumberMax();
            Console.WriteLine($" Max number between {number1} and {number2} is : {max.GetMaxNumber(number1, number2)}");
        }

        private static void EnglishInt()
        {
            var convertUtil = new EnglishInt();
            int num = 100000;
            Console.WriteLine($"{convertUtil.Convert(num)}");
        }
    }
}
