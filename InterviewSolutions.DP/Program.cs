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
    }
}
