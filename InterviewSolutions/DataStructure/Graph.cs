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
        public List<GraphNode> _nodes { get; set; }

        public Graph(List<GraphNode> nodes)
        {
            _nodes = new List<GraphNode>();
        }

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

        public void Add_Vertex(Graph G, GraphNode source, GraphNode des)
        {
            if (source != null && !G._nodes.Contains(source))
                G._nodes.Add(source);

            if (des != null && !G._nodes.Contains(des))
                G._nodes.Add(des);

            if (source.Neighbors == null)
            {
                source.Neighbors = new List<GraphNode>();
                source.Neighbors.Add(des);
            }
            else if (!source.Neighbors.Contains(des))
                source.Neighbors.Add(des);
        }

    }
    public class GraphNode
    {
        public string Name { get; set; }


        public List<GraphNode> Neighbors { get; set; }
        public bool visited { get; set; }
    }
}

