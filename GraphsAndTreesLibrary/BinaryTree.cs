using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTreesLibrary
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree? left;
        public BinaryTree? right;

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
  