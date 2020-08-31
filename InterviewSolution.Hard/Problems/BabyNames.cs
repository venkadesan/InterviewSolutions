using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class BabyNames
    {
        private Graph constructGraph(Dictionary<string, int> names)
        {
            Graph g = new Graph();
            foreach (var entry in names)
            {
                g.CreateNode(entry.Key,entry.Value);
            }
            return g;
        }
    }
}
