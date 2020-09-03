using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class KthMultiple
    {
        public int GetKthMultiple(int k)
        {
            int val = 0;
            if (k < 0)
            {
                return 0;
            }
            var queue3 = new LinkedList<int>();
            var queue5 = new LinkedList<int>();
            var queue7 = new LinkedList<int>();
            queue3.AddFirst(1);
            for (int i = 0; i <= k; i++)
            {
                int v3 = queue3.Count > 0 ? queue3.First.Value : int.MaxValue;
                int v5 = queue5.Count > 0 ? queue5.First.Value : int.MaxValue;
                int v7 = queue7.Count > 0 ? queue7.First.Value : int.MaxValue;

                val = Math.Min(v3, Math.Min(v5, v7));

                if (val == v3)
                {
                    queue3.RemoveLast();
                    queue3.AddFirst(3 * val);
                    queue5.AddFirst(5 * val);
                }
                else if (val == v5)
                {
                    queue5.RemoveLast();
                    queue5.AddFirst(5 * val);

                }
                else if (val == v7)
                {
                    queue7.RemoveLast();
                }
                queue7.AddFirst(7 * val);
            }
            return val;
        }
    }
}
