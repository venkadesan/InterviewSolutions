using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Algorithms.Search
{
    public class RankStream
    {

        RankNode root = null;
        public int GetRank(int[] data, int numberRank)
        {
            int rank = 0;
            if (data != null && data.Length > 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Track(data[i]);
                }

                rank = root.getRank(numberRank);
            }

            return rank;
        }

        private void Track(int number)
        {
            if (root == null)
            {
                root = new RankNode(number);
            }
            else
            {
                root.insert(number);
            }
        }
    }

    public class RankNode
    {
        public int left_size { get; set; }
        public RankNode left { get; set; }
        public RankNode right { get; set; }
        public int data = 0;

        public RankNode(int d)
        {
            data = d;
        }
        public void insert(int d)
        {
            if (d <= data)
            {
                if (left != null) left.insert(d);
                else left = new RankNode(d);
                left_size++;
            }
            else
            {
                if (right != null) right.insert(d);
                else right = new RankNode(d);
            }

        }

        public int getRank(int d)
        {
            if (d == data)
            {
                return left_size;
            }
            else if (d < data)
            {
                if (left == null) return -1;
                else return left.getRank(d);
            }
            else
            {
                int right_rank = right == null ? -1 : right.getRank(d);
                if (right_rank == -1)
                    return -1;
                else
                    return left_size + 1 + right_rank;
            }
        }

    }

}