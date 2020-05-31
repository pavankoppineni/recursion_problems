using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.Models
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
    }
}
