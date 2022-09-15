using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTreesLibrary
{
    public static class GraphMethods
    {
        // Methods to map string names to GraphNode objects
        // So we can initialize the graph here instead of in
        // Main() method.

        // GetNode
        // AddEdge

        public static List<string> getNodeNames(List<string> array, GraphNode node)
        {
            HashSet<string> visitedNodes = new HashSet<string>();

            Stack<GraphNode> graphNodes = new Stack<GraphNode>();

            getNodeNamesDFS(node, visitedNodes, graphNodes, array);

            return array;
        }

        public static void getNodeNamesDFS(GraphNode node, HashSet<string> visited, Stack<GraphNode> stack, List<string> array)
        {
            stack.Push(node);

            while (stack.Count() > 0)
            {
                var topNode = stack.Pop();
                if (!visited.Contains(node.name))
                {
                    visited.Add(node.name);
                    array.Add(node.name);

                    foreach (var child in node.neighbors)
                    {
                        getNodeNamesDFS(child, visited, stack, array);
                    }
                }
            }
        }

        public static bool hasPathBFS(GraphNode source, GraphNode destination)
        {
            var nextToVisit = new Queue<GraphNode>();
            var visited = new HashSet<string>();

            nextToVisit.Enqueue(source);

            while (nextToVisit.Count > 0)
            {
                GraphNode node = nextToVisit.Dequeue();
                if (node.Equals(destination)) return true;
                if (visited.Contains(node.name)) continue;
                visited.Add(node.name);

                foreach (var neighbor in node.neighbors)
                {
                    nextToVisit.Enqueue(neighbor);
                }
            }

            return false;
        }
    }
}
