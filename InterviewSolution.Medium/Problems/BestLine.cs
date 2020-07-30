using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class BestLine
    {

        #region public methods
        public Line FindBestLine(GraphPoint[] points)
        {
            var lineByScope = GetListOfLines(points);
            return GetBestLine(lineByScope);
        }
        #endregion

        #region private methods

        private Dictionary<double, List<Line>> GetListOfLines(GraphPoint[] points)
        {
            var linesBySlope = new Dictionary<double, List<Line>>();
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    Line line = new Line(points[i], points[j]);
                    double key = Line.floorToNearestEpislon(line.slope);
                    if (!linesBySlope.ContainsKey(key))
                    {
                        linesBySlope.Add(key, new List<Line>());
                    }
                    linesBySlope[key].Add(line);
                }
            }
            return linesBySlope;
        }

        private Line GetBestLine(Dictionary<double, List<Line>> linesBySlope)
        {
            Line bestLine = null;
            int bestCount = 0;
            var slopes = linesBySlope.Keys;
            foreach (double slope in slopes)
            {
                List<Line> lines = linesBySlope[slope];
                foreach (var line in lines)
                {
                    int count = CountEquivalentLines(linesBySlope, line);
                    if (count > bestCount)
                    {
                        bestLine = line;
                        bestCount = count;
                        //bestLine.Print();
                        Console.WriteLine($" best count: {bestCount}");
                    }

                }
            }
            return null;
        }

        private int CountEquivalentLines(Dictionary<double, List<Line>> linesBySlope, Line line)
        {
            double key = Line.floorToNearestEpislon(line.slope);
            int count = CountEquivalentLines(linesBySlope[key], line);
            if (linesBySlope.ContainsKey(key - Line.epsilon))
            {
                count += CountEquivalentLines(linesBySlope[key - Line.epsilon], line);
            }
            if (linesBySlope.ContainsKey(key + Line.epsilon))
            {
                count += CountEquivalentLines(linesBySlope[key + Line.epsilon], line);
            }
            return count;
        }

        private int CountEquivalentLines(List<Line> lines, Line line)
        {
            if (lines == null) return 0;
            int count = 0;
            foreach (Line pLine in lines)
            {
                if (pLine.IsEquivalent(line))
                {
                    count++;
                }
            }
            return count;

        }
        #endregion

        #region Line Class
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
        #endregion

        #region Graph point

        public class GraphPoint
        {
            public double X { get; set; }
            public double Y { get; set; }

            public GraphPoint(double _x, double _y)
            {
                X = _x;
                Y = _y;
            }
        }
        #endregion

    }

}
