using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTreesLibrary
{
    // Graph using an Adjacency List

    // Every vertex (or node) stores a list of adjacent vertices.
    // In an undirected graph, an edge like (a, b) would be stored twice.
    // Once in a's adjacent vertices and once in b's adjacent vertices.

    // We use a Graph class because unlike a tree, the nodes don't have to be connected.

    public class Graph
    {
        public Node[] nodes;
    }

    public class Node
    {
        public string name;
        public Node[] children;
    }

    // GetNode
    // AddEdge


}
