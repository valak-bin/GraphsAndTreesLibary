using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GraphsAndTreesLibrary
{
    public class TreeMethods
    {
        // Static methods

        // Average Time: O(log n) 
        // Average Space: O(1)

        // Takes in a BST node and a target
        public static int FindClosestValueInBST(BST tree, int target)
        {
            // Write a helper method to keep track of the closest value variable
            return FindClosestValueInBST(tree, target, tree.value);           
        }

        // Takes in the closest value as a parameter
        public static int FindClosestValueInBST(BST tree, int target, int closest)
        {
            BST currentNode = tree;
            while (currentNode != null)
            {
                if (Math.Abs(target - closest) > Math.Abs(target - currentNode.value))
                {
                    closest = currentNode.value;
                }

                if (target < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else if (target > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else break;
            }
            return closest;
        }



    }
}
