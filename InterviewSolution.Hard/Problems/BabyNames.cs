using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class BabyNames
    {

        #region TrulyMostPopular
        public Dictionary<string, int> TrulyMostPopular(Dictionary<string, int> names, List<Synonym> synonyms)
        {
            // Construct graph
            Graph graph = constructGraph(names);
            ConnectEdges(graph, synonyms);
            return GetTrueFrequencies(graph);

        }
        #endregion


        #region constructGraph
        private Graph constructGraph(Dictionary<string, int> names)
        {
            Graph g = new Graph();
            foreach (var entry in names)
            {
                g.CreateNode(entry.Key, entry.Value);
            }
            return g;
        }
        #endregion


        #region ConnectEdges
        private void ConnectEdges(Graph G, List<Synonym> synonyms)
        {
            foreach (var Synonym in synonyms)
            {
                G.AddEdges(Synonym.Name, Synonym.SynonymName);
            }
        }
        #endregion


        #region GetTrueFrequencies
        /// <summary>
        /// Do a DFS on each node, if node has been visited before, then it is component has already computed.
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        private Dictionary<string, int> GetTrueFrequencies(Graph graph)
        {
            var rootNames = new Dictionary<string, int>();
            foreach (var node in graph.Nodes)
            {
                if (!node.IsVisited)
                {
                    int frequency = GetComponentFrequency(node);
                    rootNames.Add(node.Name, frequency);
                }
            }
            return rootNames;
        }
        #endregion



        #region GetComponentFrequencies
        private int GetComponentFrequency(GraphNode node)
        {
            if (node.IsVisited) return 0;
            node.IsVisited = true;
            int sum = node.Count;
            foreach (var aNode in node.AdjacentNodes)
            {
                sum += GetComponentFrequency(aNode);
            }
            return sum;
        }
        #endregion

       public class Synonym
        {

            public Synonym(string name, string synonymName)
            {
                Name = name;
                SynonymName = synonymName;
            }
            public string Name { get; set; }
            public string SynonymName { get; set; }
        }
    }
}
