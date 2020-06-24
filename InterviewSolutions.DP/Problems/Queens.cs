using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class Queens
    {
        #region private variables
        int GRID_SIZE = 8;
        #endregion


        #region PlaceQueen 
        public void placeQueens(int row, int[] columns, List<int[]> results)
        {
            if (row == GRID_SIZE)
            {
                int[] clonedColumns = new int[columns.Length];
                columns.CopyTo(clonedColumns, 0);
                results.Add(clonedColumns);
            }
            else
            {
                for (int col = 0; col < GRID_SIZE; col++)
                {
                    if (checkValid(columns, row, col))
                    {
                        columns[row] = col;
                        placeQueens(row + 1, columns, results);
                    }
                }
            }
        }
        #endregion

        #region CheckValid
        // check if (row1,column1) is a valid spot for a queen by checking if there is a queen in the same row.
        private bool checkValid(int[] columns, int row1, int column1)
        {
            for (int row2 = 0; row2 < row1; row2++)
            {
                int column2 = columns[row2];
                if (column1 == column2)
                {
                    return false;
                }

                int columnDistance = Math.Abs(column2 - column1);
                int rowDistance = row1 - row2;
                if (columnDistance == rowDistance)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

    }
}
