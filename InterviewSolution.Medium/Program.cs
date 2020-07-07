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
        }

        private static void NumberSwap()
        {
            NumberSwapper swapper = new NumberSwapper();
            int a = 9;
            int b = 5;
            swapper.SwapNumber(a, b);
        }
    }
}
