using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class PondSizes
    {
        #region public methods
        public List<int> ComputePondSizes(int[,] land)
        {
            var sizes = new List<int>();
            if (land != null && land.Length > 0)
            {
                bool[,] visited = new bool[land.GetLength(0), land.GetLength(1)];
                for (int r = 0; r < land.GetLength(0); r++)
                {
                    for (int c = 0; c < land.GetLength(1); c++)
                    {
                        int size = computeSize(land, visited, r, c);
                        if (size > 0)
                        {
                            sizes.Add(size);
                        }
                    }
                }

            }
            return sizes;
        }
        #endregion

        #region private methods
        private int computeSize(int[,] land, bool[,] visited, int row, int col)
        {
            int size = 1;

            if (row < 0 || col < 0 || row >= land.GetLength(0) || col >= land.GetLength(1) || visited[row, col] || land[row, col] != 0)
            {
                return 0;
            }
            visited[row, col] = true;
            for (int dr = -1; dr <= 1; dr++)
            {
                for (int dc = -1; dc <= 1; dc++)
                {
                    size += computeSize(land, visited, row + dr, col + dc);
                }
            }
            return size;
        }
        #endregion


    }
}
