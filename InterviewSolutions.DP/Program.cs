using InterviewSolutions.DP.Problems;
using System;

namespace InterviewSolutions.DP
{
    class Program
    {
        static void Main(string[] args)
        {

            // Triple step
            //TripleStep();
            // Robot Grid problem
            RobotGrid();
            // magic index problem
            MagicIndex();
            
           

        }


        private static void TripleStep()
        {
            //1.Triple steps
            Console.WriteLine($"{TripleSteps.CountWays(5)}");
        }

        private static void RobotGrid()
        {

            bool[][] matrix = new bool[][]{
                                            new bool[] { true, true,false},
                                            new bool[] { true, true,true},
                                            new bool[] { true, false, true }
            };
            Grid grid = new Grid();
            var path = grid.getPath(matrix);
        }


        private static void MagicIndex()
        {
            int[] array = new int[] { -3, -2, -1, 1, 2, 3, 5, 7};
            MagicIndex index = new MagicIndex();
            Console.WriteLine($"{index.MagicFast(array)}");
        }
    }
}
