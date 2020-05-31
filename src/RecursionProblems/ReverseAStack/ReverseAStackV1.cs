using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.ReverseAStack
{
    /// <summary>
    /// https://www.geeksforgeeks.org/reverse-a-stack-using-recursion/
    /// </summary>
    public class ReverseAStackV1
    {
        public void ReverseStack()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
        }

        private void ReverseStack(Stack<int> stack)
        {
        }
    }
}
