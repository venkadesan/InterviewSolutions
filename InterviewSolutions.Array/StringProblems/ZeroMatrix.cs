using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Array.StringProblems
{
    public class ZeroMatrix
    {
        public void setZeros(int?[,] matrix)
        {
            bool[] row = new bool[matrix.GetLength(0)];
            bool[] column = new bool[matrix.GetLength(1)];

            // Storing the rows and columns with index value of 0.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            // Nullify Row
            for (int i = 0; i < row.GetLength(0); i++)
            {
                if (row[i])
                {
                    NullifyRow(matrix, i);
                }
            }

            // Nullify Columns
            for (int j = 0; j < column.Length; j++)
            {
                if (column[j])
                {
                    NullifyColumn(matrix, j);
                }
            }
        }

        private void NullifyRow(int?[,] matrix, int row)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[row, j] = null;
            }
        }

        private void NullifyColumn(int?[,] matrix, int col)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, col] = null;
            }
        }
    }
}
