using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP
{

    #region Grid
    public class Grid
    {

        #region getPath
        /// <summary>
        ///  Getting maze path in M * N matrix
        /// </summary>
        /// <param name="maze"></param>
        /// <returns></returns>
        public List<Point> getPath(bool[][] maze)
        {
            if (maze == null || maze.Length == 0)
            {
                return null;
            }
            List<Point> path = new List<Point>();
            HashSet<Point> failedPoints = new HashSet<Point>();
            if (getPath(maze, maze.Length - 1, maze[0].Length - 1, path, failedPoints))
            {
                return path;
            }
            return null;
        }
        #endregion

        #region private method
        private bool getPath(bool[][] maze, int row, int col, List<Point> path, HashSet<Point> failedPoints)
        {
            if (col < 0 || row < 0 || !maze[row][col])
            {
                return false;
            }
            Point p = new Point(row, col);
            //already visisted this cell ,return false.
            if (failedPoints.Contains(p))
            {
                return false;
            }

            bool isAtOrigin = (row == 0) && (col == 0);

            // if there is a path from start to my current location, add my location.
            if (
                isAtOrigin
                || getPath(maze, row, col - 1, path, failedPoints)
                || getPath(maze, row - 1, col, path, failedPoints)
                )
            {
                path.Add(p);
                return true;
            }
            // no path found - add to failed list.
            failedPoints.Add(p);
            return false;
        }
        #endregion

    }
    #endregion


    #region Point
    public class Point
    {
        public int row { get; set; }
        public int col { get; set; }
        public Point(int _row, int _col)
        {
            row = _row;
            col = _col;
        }
    }
    #endregion

}
