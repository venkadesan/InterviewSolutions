using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class BestLine
    {

        public Line FindBestLine(GraphPoint[] points)
        {
            Dictionary<double, Line> lineByScope = GetListOfLines(points);

            return GetBestLine(lineByScope);
        }

        public Dictionary<double, Line> GetListOfLines(GraphPoint[] points)
        {
            return null; 
        }

        public Line GetBestLine(Dictionary<double, Line> linesBySlope)
        {
            return null; 
        }



        public class Line
        {
            public static double epsilon = .0001;
            public double slope, intercept;
            private bool infinite_slope = false;

            //public Line(Graph)
        }

        public class GraphPoint
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }


}
