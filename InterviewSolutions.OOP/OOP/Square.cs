using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.OOP
{

    public static class Area
    {
        public static double ComputeAreaModernIs(object shape)
        {
            if (shape is Square s)
            {
                return s.Side * s.Side;
            }
            else if (shape is Circle c)
            {
                return Math.PI * c.Radius * c.Radius;
            }
            else if (shape is Trianage T)
            {
                return (T.Base * T.Height) / 2;
            }
            else if (shape is Rectange R)
            {
                return R.Height * R.Length;
            }
            throw new ArgumentException(message: "Shape is not a recognized shape", paramName: nameof(shape));
        }
    }

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
        public Trianage(double @base, double height)
        {
            Base = @base;
            Height = @height;
        }
    }

}
