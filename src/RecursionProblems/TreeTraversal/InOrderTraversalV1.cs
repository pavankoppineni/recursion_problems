using RecursionProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.TreeTraversal
{
    /// <summary>
    /// https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
    /// </summary>
    public class InOrderTraversalV1
    {
        public Stack<Node> Traverse(BinaryTree binaryTree)
        {
            var nodes = new Stack<Node>();
            Traverse(binaryTree.Root, nodes);
            return nodes;
        }

        private void Traverse(Node node, Stack<Node> nodes)
        {
            if (node == null)
            {
                return;
            }
            Traverse(node.Left, nodes);
            nodes.Push(node);
            Traverse(node.Right, nodes);
        }
    }
}
