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
            int col = matrix.GetLength(0) - 1;
            while (row < matrix.Length && col >= 0)
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

    }
}
