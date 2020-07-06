using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Algorithms.Search
{
    public class SortedMatrixSearch
    {
        //Solution1 :Naive Solution.

        public bool findElement(int[,] matrix, int elem)
        {
            int row = 0;
            int col = matrix.GetLength(1) - 1;
            while (row < matrix.GetLength(0) && col >= 0)
            {
                if (matrix[row, col] == elem)
                {
                    return true;
                }
                else if (matrix[row, col] > elem)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }
            return false;
        }

        public Coordinate findElelement2(int[,] matrix, int elem)
        {
            Coordinate origin = new Coordinate(0, 0);
            Coordinate dest = new Coordinate(matrix.GetLength(0) - 1, matrix.GetLength(1) - 1);
            return findElement(matrix, origin, dest, elem);
        }

        public Coordinate findElement(int[,] matrix, Coordinate origin, Coordinate dest, int elem)
        {
            if (!origin.inbounds(matrix) || !dest.inbounds(matrix))
            {
                return null;
            }

            if (matrix[origin.row, origin.col] == elem)
            {
                return origin;
            }
            else if (!origin.isBefore(dest))
            {
                return null;
            }
            Coordinate start = (Coordinate)origin.Clone();
            int diagDist = Math.Min(dest.row - origin.row, dest.col - origin.col);
            Coordinate end = new Coordinate(start.row + diagDist, start.col + diagDist);
            Coordinate p = new Coordinate(0, 0);

            // Do Binary Search
            while (start.isBefore(end))
            {
                p.setToAverage(start, end);
                if (elem > matrix[p.row, p.col])
                {
                    start.row = p.row + 1;
                    start.col = p.col + 1;
                }
                else
                {
                    end.row = p.row - 1;
                    end.col = p.col - 1;
                }
            }
            return ParitionAndSearch(matrix, origin, dest, start, elem);
        }

        private Coordinate ParitionAndSearch(int[,] matrix, Coordinate origin, Coordinate dest, Coordinate pivot, int elem)
        {
            Coordinate lowerLeftOrigin = new Coordinate(pivot.row, origin.col);
            Coordinate lowerLeftDet = new Coordinate(dest.row, pivot.col - 1);
            Coordinate upperRightOrigin = new Coordinate(origin.row, pivot.col);
            Coordinate upperRightDet = new Coordinate(pivot.row - 1, dest.col);

            Coordinate lowerLeft = findElement(matrix, lowerLeftOrigin, lowerLeftDet, elem);
            if (lowerLeft == null)
            {
                return findElement(matrix, upperRightOrigin, upperRightDet, elem);
            }
            return lowerLeft;
        }


        public class Coordinate : ICloneable
        {
            public int row { get; set; }
            public int col { get; set; }
            public Coordinate(int r, int c)
            {
                row = r;
                col = c;
            }

            public object Clone()
            {
                return new Coordinate(row, col);
            }

            public bool inbounds(int[,] matrix)
            {
                return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
            }

            public bool isBefore(Coordinate p)
            {
                return row <= p.row && col <= p.col;
            }

            public void setToAverage(Coordinate min, Coordinate max)
            {
                row = (min.row + max.row) / 2;
                col = (min.col + max.col) / 2;
            }
        }

    }
}
