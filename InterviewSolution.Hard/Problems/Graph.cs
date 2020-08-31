using System.Collections.Generic;
using System.Linq;

namespace InterviewSolution.Hard.Problems
{
    public class Graph
    {
        public List<GraphNode> Nodes { get; set; }
        public Graph()
        {

        }
        public void CreateNode(string name)
        {
            var newNode = new GraphNode(name);
            if (!Nodes.Contains(newNode))
            {
                Nodes.Add(newNode);
            }
        }

        public void AddEdges(string nodeName1, string nodeName2)
        {
            if (!string.IsNullOrWhiteSpace(nodeName1) && !string.IsNullOrWhiteSpace(nodeName2))
            {
                var node1 = Nodes.Where(node => node.Equals(nodeName1)).FirstOrDefault();
                var node2 = Nodes.Where(node => node.Equals(nodeName2)).FirstOrDefault();
                if(node1!=null && node2!=null)
                {
                    if (!node1.AdjacentNodes.Contains(node2))
                    {
                        node1.AdjacentNodes.Add(node2);
                    }
                    if (!node2.AdjacentNodes.Contains(node1))
                    {
                        node2.AdjacentNodes.Add(node1);
                    }
                }
            }
        }
    }

    public class GraphNode
    {
        public string Name { get; set; }
        public GraphNode(string name)
        {
            Name = name;
        }
        public List<GraphNode> AdjacentNodes { get; set; }

    }

}
