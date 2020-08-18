using System;

namespace InterviewSolutions.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pattern Matching problem.
            PatternMatching();
        }


        private static void PatternMatching()
        {
            var square = new Square(5.0);
            var triangle = new Trianage(1.0, 2.0);
            var rectange = new Rectange(1.0, 5.0);
            var circle = new Circle(2.0);
            Console.WriteLine($"SQUARE AREA :  { Area.ComputeAreaModernIs(square)}");
            Console.WriteLine($"TRIANGLE AREA : { Area.ComputeAreaModernIs(triangle)}");
            Console.WriteLine($"RECTANGLE AREA :  { Area.ComputeAreaModernIs(rectange)}");
            Console.WriteLine($"CIRCEL AREA: { Area.ComputeAreaModernIs(circle)}");
        }
    }
}
