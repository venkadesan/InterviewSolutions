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
        public void DFS(GraphNode root)
        {
            if (root == null) return;
            Visit(root);
            root.State = State.Visited;
            if (root.Neighbors != null)
            {
                foreach (GraphNode node in root.Neighbors)
                {
                    if (node.State != State.UnVisited)
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

        public bool IsRouteExists(Graph G, GraphNode source, GraphNode dest)
        {
            if (source == dest) return true;
            LinkedList<GraphNode> q = new LinkedList<GraphNode>();
            List<GraphNode> nodes = G.Nodes;
            if (nodes != null && nodes.Count > 0)
            {
                foreach (GraphNode n in nodes)
                {
                    n.State = State.UnVisited;
                }
                source.State = State.Visiting;
                q.AddLast(source);
                while (q.Count > 0)
                {
                    GraphNode node = q.First();
                    if (node != null)
                    {
                        q.RemoveFirst();
                        if (node.Neighbors != null)
                        {
                            foreach (GraphNode adjNode in node.Neighbors)
                            {
                                Console.WriteLine($"Checking neighbors of {node.Name}");
                                if (adjNode.State == State.UnVisited)
                                {
                                    if (adjNode == dest)
                                    {
                                        Console.WriteLine($"Route  exitss neighbors of {node.Name} to {adjNode.Name}");
                                        return true;
                                    }
                                    else
                                    {
                                        adjNode.State = State.Visiting;
                                        q.AddLast(adjNode);
                                    }
                                }
                            }
                            node.State = State.Visited;
                        }
                    }
                }
            }

            return false;
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
        public State State { get; set; }
    }
}

