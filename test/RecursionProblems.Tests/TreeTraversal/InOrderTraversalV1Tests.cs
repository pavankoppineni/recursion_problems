using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursionProblems.Models;
using RecursionProblems.TreeTraversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.Tests.TreeTraversal
{
    [TestClass]
    public class InOrderTraversalV1Tests
    {
        [TestMethod]
        public void GivenBinaryTree_Traverse_ReturnsListOfNodesInOrder()
        {
            //Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            var inorderTraversal = new InOrderTraversalV1();
            var expectedNodesInOrder = new Stack<Node>();
            expectedNodesInOrder.Push(new Node(4));
            expectedNodesInOrder.Push(new Node(2));
            expectedNodesInOrder.Push(new Node(5));
            expectedNodesInOrder.Push(new Node(1));
            expectedNodesInOrder.Push(new Node(3));

            //Act
            var actualNodesInOrder = inorderTraversal.Traverse(tree);

            //Assert
            while (expectedNodesInOrder.TryPeek(out Node node))
            {
                var expectedNode = expectedNodesInOrder.Pop();
                var actualNode = actualNodesInOrder.Pop();
                Assert.AreEqual(expectedNode.Value, actualNode.Value);
            }
        }
    }
}
