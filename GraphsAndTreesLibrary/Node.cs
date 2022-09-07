using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTreesLibrary
{
    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }   
        
        public Node AddChild(string name)
        {
            Node child = new Node(name);
            children.Add(child);
            return this;
        }

        public List<string> DepthFirstSearch(List<string> array)
        // Time: O(v + e) where v is the # of vertics and e the edges
        // Space: O(v)
        {
            array.Add(this.name);
            for (int i = 0; i < children.Count; i++)
            {
                children[i].DepthFirstSearch(array);
            }
            return array;
        }
    }
}
