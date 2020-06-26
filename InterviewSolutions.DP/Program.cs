﻿using System;
using System.Collections.Generic;
using InterviewSolutions.DP.Problems;


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
            // Power set
            PowerSet();
            // Placing queen
            PlaceQueen();
            // Paren
            Paren();
            // Tower of hanoi problem
            Tower();
            // Recursive multiply
            RecursiveMultiply();

            // Permutation without duplicates
            PermutationsWithoutDups();

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
            int[] array = new int[] { -3, -2, -1, 1, 2, 3, 5, 7 };
            MagicIndex index = new MagicIndex();
            Console.WriteLine($"{index.MagicFast(array)}");
        }

        private static void PowerSet()
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4 };
            int index = 0;
            PowerSet set = new PowerSet();
            /*var subsets = set.GetSubSets(integers, index)*/
            ;
            var subsets = set.GetSubSets2(integers);

            if (subsets?.Count > 0)
            {
                foreach (var subset in subsets)
                {
                    Console.WriteLine($"Power set : {string.Join(",", subset.ToArray())}");
                }
            }


        }

        private static void PlaceQueen()
        {
            Queens queens = new Queens();
            List<int[]> results = new List<int[]>();
            int[] Columns = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
            int row = 0;
            queens.placeQueens(row, Columns, results);
        }

        private static void Paren()
        {
            Parens paren = new Parens();
            int count = 3;
            var result = paren.GeneateParen(count);
            if (result != null && result.Count > 0)
            {
                foreach (var res in result)
                {
                    Console.WriteLine($"Paren : {res}");
                }
            }
        }

        private static void Tower()
        {
            Towers towers = new Towers();
            towers.MoveTowers();
        }

        private static void RecursiveMultiply()
        {
            Multiply multiply = new Multiply();
            int n1 = 8;
            int n2 = 7;
            Console.WriteLine($"Recursive Multiplication {multiply.RecuriveMultiply(n1, n2)}");
        }

        private static void PermutationsWithoutDups()
        {
            PermutationsWithoutDups perms = new PermutationsWithoutDups();
            string str = "abc";
            var permResult = perms.GetPerms(str);
            if (permResult != null && permResult.Count > 0)
            {
                foreach (var perm in permResult)
                {
                    Console.WriteLine($"Perm {perm}");
                }
            }
        }

    }
}
