using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class Towers
    {
        public void MoveTowers()
        {
            int n = 3;
            Tower[] towers = new Tower[n];
            for (int i = 0; i < n; i++)
            {
                towers[i] = new Tower(i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                towers[0].add(i);
            }
            towers[0].moveDisks(n, towers[2], towers[1]);
        }
    }

    #region Tower class
    #endregion
    public class Tower
    {
        private Stack<int> disks;
        private int index = 0;

        public Tower(int i)
        {
            disks = new Stack<int>();
            index = i;
        }
        public int Index()
        {
            return index;
        }
        public void add(int d)
        {
            if (disks.Count != 0 && disks.Peek() <= d)
            {
                Console.WriteLine($"Error placing disk: {d}");
            }
            else
            {
                disks.Push(d);
            }
        }

        public void MoveTopTo(Tower t)
        {
            int top = disks.Pop();
            t.add(top);
        }

        public void moveDisks(int n, Tower destination, Tower buffer)
        {
            if (n > 0)
            {
                moveDisks(n - 1, buffer, destination);
                MoveTopTo(destination);
                buffer.moveDisks(n - 1, destination, this);
            }
        }
    }
}
