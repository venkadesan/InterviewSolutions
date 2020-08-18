using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.OOP.OOP
{
    public class Square
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
    }

    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public struct Rectange
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Rectange(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }

    public class Trianage
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Trianage(double @base,double height)
        {
            Base = @base;
            Height = @height;
        }
    }

}
