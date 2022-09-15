using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTreesLibrary
{
    public class GraphNode
    {
        public string name;
        public List<GraphNode> neighbors = new List<GraphNode>();

        public GraphNode(string name)
        {
            this.name = name;
        }   
        
        public GraphNode AddChild(string name)
        {
            GraphNode child = new GraphNode(name);
            neighbors.Add(child);
            return this;
        }


    }
}
