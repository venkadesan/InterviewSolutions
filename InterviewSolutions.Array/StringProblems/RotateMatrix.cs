using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Array.StringProblems
{
    public class RotateMatrix
    {
        public bool Rotate(int[,] matrix)
        {
            if (matrix.Length == 0 || matrix.GetLength(0) != matrix.GetLength(1))
            {
                return false;
            }

            int n = matrix.GetLength(0);
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offSet = i - first;
                    int top = matrix[first, i]; // saving top
                    matrix[first, i] = matrix[last - offSet, first]; // Left top
                    matrix[last - offSet, first] = matrix[last, last - offSet]; // bottom --> left
                    matrix[last, last - offSet] = matrix[i, last];
                    matrix[i, last] = top; //rogjt <= saved top

                }
            }

            return true;
        }
    }
}
