using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{

    public enum State
    {
        UnVisited,
        Visited,
        Visiting
    }
    public class Graph
    {
        public List<GraphNode> Nodes { get; set; }

        #region constructor
        public Graph(List<GraphNode> nodes)
        {
            Nodes = nodes;
        }

        #endregion


        #region Public Method
        public void Add_Vertex(GraphNode source, GraphNode destination)
        {
            if (source.Neighbors == null)
            {
                source.Neighbors = new List<GraphNode>();
            }
            if (!source.Neighbors.Contains(destination))
            {
                source.Neighbors.Add(destination);
            }
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
        public State State { get; set; }
    }
}

