using System;
using InterviewSolution.Hard.Problems;

namespace InterviewSolution.Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adding without Plus
            AddingWithoutPlus();

            // Shuffle Array
            ShuffleArray();
        }

        private static void AddingWithoutPlus()
        {
            var add = new AddWithoutPlus();
            int a = 525;
            int b = 799;
            Console.WriteLine($"Adding without Plus Symobl {add.Add(a, b)}");
        }

        private static void ShuffleArray()
        {
            var shuffleArray = new Shuffle();
            var array = new int[52];
            for (int i = 1; i <= 52; i++)
            {
                array[i - 1] = i;
            }
            shuffleArray.ShuffleArray(array);
        }

    }
}
