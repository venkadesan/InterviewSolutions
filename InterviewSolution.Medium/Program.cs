using System;
using System.Collections.Generic;
using InterviewSolution.Medium.Problems;

namespace InterviewSolution.Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number swapper
            NumberSwap();
            // Word Frequencies
            WordFrequencies();
            // Two line intersection
            TwoLineIntersection();
            // Factorial Zeroes
            FactorialZeroes();
            // Smallest difference in the array
            smallestDifference();
            // Get max number
            GetMaxNumber();
            // Convert Number to it's equal english words.
            EnglishInt();
            // Tic Tac Won
            ticTacWon();
            // Operations
            Operations();
            // Max Alive problem.
            MaxAliveyear();
            // Diving board
            DivingBoard();
            // BiSectSqures
            BiSectSqures();
            // Best Lines
            BestLine();
            // Master mind problem
            MasterMind();
            // SubSort
            SubSort();
            // Contiguous Sequence
            ContiguousSequence();
            // Pattern Matching
            PatternMatching();
            // Pond Size  problem  
            PondSize();

        }

        private static void NumberSwap()
        {
            NumberSwapper swapper = new NumberSwapper();
            int a = 9;
            int b = 5;
            swapper.SwapNumber(a, b);
        }

        private static void WordFrequencies()
        {
            WordFrequencies freq = new WordFrequencies();
            string[] book = new string[] { "test", "test2", "test" };
            var word = "test";

            // Solution 1
            Console.WriteLine($"word frequencies solution1 {freq.GetFrequency(book, word)}");

            // solution 2
            var wordfreq = freq.setupDictionary(book, word);
            Console.WriteLine($"word Frequencies Solution 2  {freq.GetFrequency(wordfreq, word)}");
        }

        private static void TwoLineIntersection()
        {
            LineIntersection intersectUtil = new LineIntersection();

            Point start1 = new Point(1, 4);
            Point end1 = new Point(4, 5);
            Point start2 = new Point(1, 5);
            Point end2 = new Point(4, 4);
            var interesectPoint = intersectUtil.Intersection(start1, end1, start2, end2);
            if (interesectPoint != null)
            {
                Console.WriteLine($"is two line intersect ? :  {interesectPoint.x} {interesectPoint.y}");
            }

        }

        private static void FactorialZeroes()
        {
            FactorialZeros factZeroes = new FactorialZeros();
            int number = 19;
            Console.WriteLine($" {factZeroes.countFactZeroes(number)}");

        }


        private static void smallestDifference()
        {
            SmallestDifference smallDiff = new SmallestDifference();
            int[] array1 = new int[] { 1, 3, 15, 11, 2 };
            int[] array2 = new int[] { 23, 127, 235, 19, 8 };
            Console.WriteLine($"The smallest difference in the array :  {smallDiff.findSmallestDifference(array1, array2)}");

        }

        private static void GetMaxNumber()
        {
            int number1 = 3;
            int number2 = 10;
            NumberMax max = new NumberMax();
            Console.WriteLine($" Max number between {number1} and {number2} is : {max.GetMaxNumber(number1, number2)}");
        }

        private static void EnglishInt()
        {
            var convertUtil = new EnglishInt();
            int num = 1234567890;
            Console.WriteLine($"{convertUtil.Convert(num)}");
        }

        private static void ticTacWon()
        {
            TicTacWon tacWon = new TicTacWon();
            Piece[,] board = new Piece[,] { { Piece.Blue,Piece.Red,Piece.Blue },
                                             { Piece.Blue,Piece.Blue,Piece.Empty },
                                             { Piece.Blue,Piece.Red, Piece.Blue }};
            int row = 2;
            int col = 2;
            var piece = tacWon.hasWon(board, row, col);
            Console.WriteLine($"Peice Won {piece}");

        }

        private static void Operations()
        {
            int a = 5;
            int b = 10;
            Operations ops = new Operations();
            Console.WriteLine($"Subtracting {a} from {b} is {ops.minus(a, b)}");

            Console.WriteLine($"Mutliplication {a} from {b} is {ops.multiply(a, b)}");

            Console.WriteLine($"Division {b} from {a} is {ops.divide(b, a)}");
        }

        private static void MaxAliveyear()
        {
            LivingPeople people = new LivingPeople();
            var peoples = new List<People>()
            {
                new People(12,15),
                new People(20,90),
                new People(01,72),
                new People(10,98),
                new People(23,82),
                new People(13,98),
                new People(90,98),
                new People(83,99),
                new People(75,94)
            };
            int minYear = 01;
            int MaxYear = 99;

            Console.WriteLine($"Max year { people.GetMaxAliveYear(peoples.ToArray(), minYear, MaxYear)}");
        }

        private static void DivingBoard()
        {
            DivingBoard board = new DivingBoard();
            int MaxPlanksofWoods = 10;
            int shorterWoodLength = 5;
            int longerWoodLength = 6;
            var ways = board.PossibleLengths(MaxPlanksofWoods, shorterWoodLength, longerWoodLength);
            if (ways != null && ways.Count > 0)
            {
                foreach (var way in ways)
                {
                    Console.WriteLine($"Possible ways {way}");
                }
            }
        }

        private static void BiSectSqures()
        {
            square square = new square(10, 15, 10, 15);
            square square1 = new square(10, 15, 10, 15);
            Line line = square1.LineCut(square);
            if (line != null)
            {
                Console.WriteLine($"Instersecting line slope: {line.slope}  Intercept:{line.yIntercept}");
            }

        }

        private static void BestLine()
        {
            var line = new BestLine();
            var points = new List<BestLine.GraphPoint>();
            points.Add(new BestLine.GraphPoint(1.0, 2.0));
            points.Add(new BestLine.GraphPoint(2.0, 2.0));
            points.Add(new BestLine.GraphPoint(3.0, 2.0));
            points.Add(new BestLine.GraphPoint(4.0, 2.0));
            points.Add(new BestLine.GraphPoint(4.0, 3.0));
            line.FindBestLine(points.ToArray());

        }

        private static void MasterMind()
        {
            var mind = new MasterMind();
            string guess = "GGRR";
            string solution = "RGBY";
            Console.WriteLine($" Estimates counts: {mind.estimate(guess, solution)} ");
        }


        private static void SubSort()
        {
            var unsortedNumbers = new int[] { 1, 2, 4, 7, 10, 11, 8, 12, 5, 6, 16, 18, 19 };
            var subsort = new SubSort();
            subsort.findUnsortedSequence(unsortedNumbers);

        }

        private static void ContiguousSequence()
        {
            var sequence = new ContiguousSequence();
            var numbers = new int[] { 2, -8, 3, -2, 4, -10 };
            Console.WriteLine($" Max Number : {sequence.GetMaxSum(numbers)}");

        }

        private static void PatternMatching()
        {
            var patternMatching = new PatternMatching();
            string value = "catcatgocatgo";
            string pattern = "aabab";
            Console.WriteLine($" Pattern Match {patternMatching.doesMatch(pattern, value)}");
        }

        private static void PondSize()
        {
            var pondSize = new PondSizes();
            int[,] land = new int[,] { { 0,2,1,0}
                                      ,{0,1,0,1 }
                                      ,{1,1,0,1 }
                                       ,{0,1,0,1 }
                                      };
            var pondSizes = pondSize.ComputePondSizes(land);
            if (pondSizes != null && pondSizes.Count > 0)
            {
                Console.WriteLine($"Pond sizes: { string.Join(",", pondSizes.ToArray())}");
            }

        }
    }
}
