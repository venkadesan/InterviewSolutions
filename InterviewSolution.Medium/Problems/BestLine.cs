using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class BestLine
    {

        public Line FindBestLine(GraphPoint[] points)
        {
            var lineByScope = GetListOfLines(points);
            return GetBestLine(lineByScope);
        }

        public Dictionary<double, List<Line>> GetListOfLines(GraphPoint[] points)
        {
            var linesBySlope = new Dictionary<double, List<Line>>();
            return linesBySlope;
        }

        public Line GetBestLine(Dictionary<double, List<Line>> linesBySlope)
        {
            Line bestLine = null;
            int bestCount = 0;
            var slopes = linesBySlope.Keys;
            foreach (double slope in slopes)
            {
                List<Line> lines = linesBySlope[slope];

            }
            return null;
        }



        public class Line
        {
            public static double epsilon = .0001;
            public double slope, intercept;
            private bool infinite_slope = false;

            public Line(GraphPoint p, GraphPoint q)
            {
                if (Math.Abs(p.X - q.X) > epsilon)
                {
                    slope = (p.Y - q.Y) / (p.X - q.X);
                    intercept = p.Y - slope * p.X; // y intercept from y = mx +b;
                }
                else
                {
                    infinite_slope = true;
                    intercept = p.X;
                }
            }

            public static double floorToNearestEpislon(double d)
            {
                int r = (int)(d / epsilon);
                return r * epsilon;
            }

            public bool IsEquivalent(object o)
            {
                Line l = (Line)o;
                if (IsEquivalent(l.slope, slope) && IsEquivalent(l.intercept, intercept) && (infinite_slope == l.infinite_slope))
                {
                    return true;
                }
                return false;
            }

            public bool IsEquivalent(double a, double b)
            {
                return (Math.Abs(a - b) < epsilon);
            }
        }

        public class GraphPoint
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }


}
