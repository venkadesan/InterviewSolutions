using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{
    public class Graph
    {
        public GraphNode[] nodes { get; set; }

        public void DFS(GraphNode root)
        {
            if (root == null) return;
             Visit(root);
            root.visited = true;
            foreach (GraphNode node in root.Neighbors)
            {
                if (!node.visited)
                {
                    DFS(node);
                }
            }

        }

        private void Visit(GraphNode node)
        {
            Console.WriteLine(node.Name);
        }
    }
    public class GraphNode
    {
        public string Name { get; set; }
        public GraphNode[] Neighbors { get; set; }
        public bool visited { get; set; }
    }
}

