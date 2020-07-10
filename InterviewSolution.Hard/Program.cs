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
        }

        private static void AddingWithoutPlus()
        {
            var add = new AddWithoutPlus();
            int a = 525;
            int b = 799;
            Console.WriteLine($"Adding without Plus Symobl {add.Add(a, b)}");
        }

    }
}
