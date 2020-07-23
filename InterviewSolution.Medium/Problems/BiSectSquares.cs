using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace InterviewSolution.Medium.Problems
{

    public class square
    {

        #region constructor
        public square()
        { }
        public square(double _left, double _right, double _top, double _bottom)
        {
            left = _left;
            right = _right;
            top = _top;
            bottom = _bottom;
            //size = 
        }
        #endregion

        public double left { get; set; }
        public double right { get; set; }
        public double top { get; set; }
        public double bottom { get; set; }
        public double size { get; set; }
        public Point Middle()
        {
            var midPoint = (right + left) / 2.0;
            var midPoint2 = (top + bottom) / 2.0;
            return new Point(midPoint, midPoint2);
        }

        public Point Extend(Point mid1, Point mid2, double size)
        {
            double xdir = mid1.x < mid2.x ? -1 : 1;
            double ydir = mid1.y < mid2.y ? -1 : 1;

            if (mid1.x == mid2.x)
            {
                return new Point(mid1.x, mid1.y + ydir * size / 2.0);
            }

            double slope = (mid1.y - mid2.y) / (mid1.x - mid2.x);
            double x1 = 0;
            double y1 = 0;

            if (Math.Abs(slope) == 1)
            {
                x1 = mid1.x + xdir * size / 2.0;
                y1 = mid1.y + ydir * size / 2.0;
            }
            else if (Math.Abs(slope) < 1)
            {
                x1 = mid1.x + xdir * size / 2.0;
                y1 = slope * (x1 - mid1.x) + mid1.y;
            }
            else
            {
                y1 = mid1.y + ydir * size / 2.0;
                x1 = (y1 - mid1.y) / slope + mid1.x;
            }

            return new Point(x1, y1);
        }


        public Line LineCut(square other)
        {

            Point p1 = Extend(Middle(), other.Middle(), size);
            Point p2 = Extend(Middle(), other.Middle(), -1 * size);
            Point p3 = Extend(other.Middle(), Middle(), other.size);
            Point p4 = Extend(other.Middle(), Middle(), -1 * other.size);

            Point start = p1;
            Point end = p1;
            Point[] points = { p2, p3, p4 };
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].x < start.x ||
                    (points[i].x == start.x &&
                    points[i].y < start.y))
                {
                    start = points[i];
                }
                else if (points[i].x > end.x ||
                        (points[i].x == end.x && points[i].y > end.y))
                {
                    end = points[i];
                }

            }

            return new Line(start, end);
        }
    }
    //public class Point
    //{
    //    public decimal x { get; set; }
    //    public decimal y { get; set; }
    //    public Point(decimal _x, decimal _y)
    //    {
    //        x = _x;
    //        y = _y;
    //    }
    //}
}
