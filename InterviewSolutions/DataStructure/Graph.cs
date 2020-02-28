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

        #region constructor
        public Graph(List<GraphNode> nodes)
        {
            _nodes = nodes;
        }

        #endregion


        #region Public Method
        public void DFS(GraphNode root)
        {
            if (root == null) return;
            Visit(root);
            root.visited = true;
            if (root.Neighbors != null)
            {
                foreach (GraphNode node in root.Neighbors)
                {
                    if (!node.visited)
                    {
                        DFS(node);
                    }
                }
            }
        }

        public void Add_Vertex(GraphNode source, GraphNode destination)
        {
            if (source.Neighbors == null) source.Neighbors = new List<GraphNode>();
            if (!source.Neighbors.Contains(destination)) source.Neighbors.Add(destination);
        }

        #endregion



        #region private methods
        private void Visit(GraphNode node)
        {
            Console.WriteLine(node.Name);
        }

        #endregion



    }
    public class GraphNode
    {
        public string Name { get; set; }

        public GraphNode(string _name)
        {
            Name = _name;
        }

        public List<GraphNode> Neighbors { get; set; }
        public bool visited { get; set; }
    }
}

