using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using InterviewSolutions.DataStructure;
namespace InterviewSolutions.Graph.Helper
{
    public class SearchHelper
    {

        #region public methods
        #region DepthFirstSearch

        /// <summary>
        ///  Depth first search using rescursive solution
        /// </summary>
        /// <param name="root"></param>
        public static void DepthFirstSearch(GraphNode root)
        {
            if (root == null) return;
            Visit(root);
            root.State = State.Visited;
            if (root.Neighbors != null && root.Neighbors.Count > 0)
            {
                foreach (GraphNode node in root.Neighbors)
                {
                    if (node.State != State.Visited)
                    {

                        DepthFirstSearch(node);
                    }
                }
            }
        }

        /// <summary>
        /// Depth first search using Iterative solution,
        /// </summary>
        /// <param name="root">starting node</param>
        public static void DepthFirstSearchIterative(GraphNode root)
        {
            if (root == null) return;
            Stack<GraphNode> nodes = new Stack<GraphNode>(); // Stack to hold list of graph nodes.
            nodes.Push(root);
            while (nodes.Count != 0)
            {
                GraphNode node = nodes.Pop();
                if (node.State != State.Visited)
                {
                    node.State = State.Visited;
                    Visit(node);
                    if (node?.Neighbors?.Count > 0)
                    {
                        foreach (var neighbor in node.Neighbors)
                        {
                            nodes.Push(neighbor);
                        }
                    }
                }

            }
        }
        #endregion


        #region BreadthFirstSearch
        /// <summary>
        ///  Breadth First Search Algorithm for Graph Data Structures.
        /// </summary>
        /// <param name="root">root of the graph</param>
        public static void BreadthFirstSearch(GraphNode root)
        {
            if (root == null) return;
            Console.WriteLine("Breadth First Search starts:");
            Queue<GraphNode> queue = new Queue<GraphNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                GraphNode node = queue.Dequeue();
                if (node.State != State.Visited)
                {
                    node.State = State.Visited;
                    Visit(node);
                }
                if (node.Neighbors != null && node.Neighbors.Count > 0)
                {
                    foreach (var neighbor in node.Neighbors)
                    {
                        if (neighbor.State != State.Visited)
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
            Console.WriteLine("Breadth First Search ends:");
        }

        #endregion


        public bool IsRouteExists(DataStructure.Graph G, GraphNode source, GraphNode dest)
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
        private static void Visit(GraphNode node)
        {
            Console.WriteLine($"visiting node:{node.Name}");
        }

        #endregion
    }
}
