using System;
using System.Collections.Generic;
using System.Text;
using InterviewSolutions.DataStructure;


namespace InterviewSolutions.Graph.Problems
{

    #region SortingUtil
    public class SortingUtil
    {

        #region TopologicalSorting

        public static void ToplogicalSortUtil(DataStructure.Graph graph, Stack<GraphNode> orderingNodes)
        {
            if (graph != null && graph.Nodes != null && graph.Nodes.Count > 0)
            {
                foreach (var node in graph.Nodes)
                {
                    Visit(node, orderingNodes);
                }
            }
        }

        #endregion

        #region visiting
        private static void Visit(GraphNode node, Stack<GraphNode> nodes)
        {
            if (node?.State == State.Visited)
            {
                return;
            }
            if (node.State != State.Visiting)
            {
                node.State = State.Visiting;
            }
            if (node.Neighbors != null && node.Neighbors.Count > 0)
            {
                foreach (var adjNode in node.Neighbors)
                {
                    Visit(adjNode, nodes);
                }
            }
            node.State = State.Visited;
            nodes.Push(node);

        }
    }
    #endregion


    #endregion

}
