using System;
using System.Collections.Generic;
using InterviewSolutions.DataStructure;
using InterviewSolutions.Graph.Helper;
using InterviewSolutions.Graph.Problems;

namespace InterviewSolutions.Graph
{
    class Program
    {
        static void Main(string[] args)
        {

            var G = BuildGraph();
            var startNode = G.Nodes[0];

            //TopologicalSorting

            TopologicalSorting(G);

            SearchHelper.BreadthFirstSearch(startNode);
            // need to reset for node search status to unvisited.
            SearchHelper.DepthFirstSearch(startNode);
            SearchHelper.DepthFirstSearchIterative(startNode);



        }

        private static DataStructure.Graph BuildGraph()
        {
            List<GraphNode> nodes = new List<GraphNode>();
            var node0 = new GraphNode("5");
            var node1 = new GraphNode("7");
            var node2 = new GraphNode("3");
            var node3 = new GraphNode("11");
            var node4 = new GraphNode("8");
            var node5 = new GraphNode("2");
            var node6 = new GraphNode("9");
            var node7 = new GraphNode("10");
            nodes.Add(node0);
            nodes.Add(node1);
            nodes.Add(node2);
            nodes.Add(node3);
            nodes.Add(node4);
            nodes.Add(node5);
            nodes.Add(node6);
            nodes.Add(node7);
            DataStructure.Graph G = new DataStructure.Graph(nodes);
            G.Add_Vertex(node0, node3);

            G.Add_Vertex(node1, node3);
            G.Add_Vertex(node1, node4);

            G.Add_Vertex(node2, node4);
            G.Add_Vertex(node2, node7);

            G.Add_Vertex(node3, node2);
            G.Add_Vertex(node3, node6);
            G.Add_Vertex(node3, node7);

            G.Add_Vertex(node4, node6);



            return G;
        }

        private static bool IsRouteExits(DataStructure.Graph G)
        {
            var source = new GraphNode("0");
            var dest = new GraphNode("1");
            SearchHelper helper = new SearchHelper();
            if (helper.IsRouteExists(G, source, dest))
            {
                Console.WriteLine($"{source.Name} Route Exists {dest.Name}");
            }
            else
            {
                Console.WriteLine($"{source.Name} Route Not Exists {dest.Name}");
            }
            return false;
        }

        private static void TopologicalSorting(DataStructure.Graph G)
        {
            var orderingNodes = new Stack<GraphNode>();
            SortingUtil.ToplogicalSortUtil(G, orderingNodes);
            if (orderingNodes?.Count > 0)
            {
                var nodes =  new List<GraphNode>();
                while (orderingNodes.Count > 0)
                {
                    nodes.Add(orderingNodes.Pop());
                }

                foreach (var node in nodes)
                {
                    Console.WriteLine($"Node Name:  {node.Name}");
                }
            }
        }
    }
}
