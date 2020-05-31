using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.StringPermutations
{
    /// <summary>
    /// https://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
    /// </summary>
    public class StringPermutationsV1
    {
        public IList<string> GeneratePermutations(string str)
        {
            var permutations = new List<string>();
            GeneratePermutations(str, 0, str.Length - 1, permutations);
            return permutations;
        }

        private void GeneratePermutations(string str, int start, int end, IList<string> permutations)
        {
            if (start == end)
            {
                permutations.Add(str);
                return;
            }

            for(var i = start; i<=end; i++)
            {
                str = Swap(str, start, i);
                GeneratePermutations(str, start + 1, end, permutations);
                str = Swap(str, start, i);
            }
        }

        private string Swap(string str, int x, int y)
        {
            var charArray = str.ToCharArray();
            var temp = charArray[x];
            charArray[x] = charArray[y];
            charArray[y] = temp;
            return new string(charArray);
        }
    }
}
