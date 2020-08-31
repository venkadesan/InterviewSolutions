﻿using System.Collections.Generic;
using System.Linq;

namespace InterviewSolution.Hard.Problems
{
    #region Graph Class
    public class Graph
    {
        #region properties
        public List<GraphNode> Nodes { get; set; }
        #endregion

        #region constructor
        public Graph()
        {

        }
        #endregion

        #region public methods

        #region CreateNode
        public void CreateNode(string name, int count)
        {
            var newNode = new GraphNode(name, count);
            if (!Nodes.Contains(newNode))
            {
                Nodes.Add(newNode);
            }
        }
        #endregion


        #region AddEdeges
        public void AddEdges(string nodeName1, string nodeName2)
        {
            if (!string.IsNullOrWhiteSpace(nodeName1) && !string.IsNullOrWhiteSpace(nodeName2))
            {
                var node1 = Nodes.Where(node => node.Equals(nodeName1)).FirstOrDefault();
                var node2 = Nodes.Where(node => node.Equals(nodeName2)).FirstOrDefault();
                if (node1 != null && node2 != null)
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
        #endregion

        #endregion

    }
    #endregion


    #region GraphNode
    public class GraphNode
    {

        #region properites
        public string Name { get; set; }
        public int Count { get; set; }

        #endregion


        #region constructor
        public GraphNode(string name, int count)
        {
            Name = name;
            Count = count;
        }
        #endregion

        #region 
        public List<GraphNode> AdjacentNodes { get; set; }

    }
    #endregion



}
