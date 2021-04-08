using System;
using System.Collections.Generic;
using System.Linq;

namespace session_03.src.lib.GraphAllPathsFinder
{
    class GraphAllPathsFinder
    {
        private List<List<GraphNode>> allPaths;
        private HashSet<GraphNode> vistedNodes;
        private List<GraphNode> localpaths;

        public List<List<GraphNode>> FindAllPaths(GraphNode start, GraphNode goal)
        {
            allPaths = new List<List<GraphNode>>();
            vistedNodes = new HashSet<GraphNode>();
            localpaths = new List<GraphNode>();

            FindAllPathsBetweenTwoNodes(start, goal);
            allPaths.Sort((l1, l2) => l1.Count - l2.Count);

            return allPaths;
        }

        private List<List<GraphNode>> FindAllPathsBetweenTwoNodes(GraphNode startNode, GraphNode endNode)
        {
            //Mark Current Node As Visited
            vistedNodes.Add(startNode);
            if (localpaths.Count == 0)
            {
                localpaths.Add(startNode);
            }

            if (startNode.DisplayName.Equals(endNode.DisplayName))
            {
                BuildPath(localpaths);
            }

            foreach (var node in startNode.Children)
            {
                if (!vistedNodes.Contains(node))
                {
                    localpaths.Add(node);
                    FindAllPathsBetweenTwoNodes(node, endNode);
                    localpaths.Remove(node);
                }
            }
            vistedNodes.Remove(startNode);
            return allPaths;
        }

        private void BuildPath(List<GraphNode> localpath)
        {
            var localbuildPath = new List<GraphNode>();
            foreach (var item in localpath)
                localbuildPath.Add(item);
            allPaths.Add(localbuildPath);
        }
    }

    class GraphNodeWithData<T> : GraphNode
    {
        public T Data { get; set; }
        public GraphNodeWithData(T data, string displayName) : base(displayName)
        {
            Data = data;
        }
    }

    class GraphNode
    {
        public string DisplayName { get; }
        public List<GraphNode> Children { get; }

        public GraphNode(string displayName)
        {
            DisplayName = displayName;
            Children = new List<GraphNode>();
        }

        public GraphNode AddChildren(GraphNode node, bool bidirect = true)
        {
            Children.Add(node);
            if (bidirect)
            {
                node.Children.Add(this);
            }
            return this;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}