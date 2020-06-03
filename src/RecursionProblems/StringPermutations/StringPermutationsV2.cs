using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.StringPermutations
{
    /// <summary>
    /// https://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
    /// </summary>
    public class StringPermutationsV2
    {
        public IList<string> GeneratePermutations(string str)
        {
            var permutations = new List<string>();
            GeneratePermutations(str, 0, str.Length - 1, permutations);
            return permutations;
        }

        private void GeneratePermutations(string str, int currentIndex, int lastIndex, IList<string> permutations)
        {
            if (currentIndex == lastIndex)
            {
                permutations.Add(str);
                return;
            }

            for (var i = currentIndex; i <= lastIndex; i++)
            {
                str = Swap(str, currentIndex, i);
                GeneratePermutations(str, currentIndex + 1, lastIndex, permutations);
                str = Swap(str, currentIndex, i);
            }
        }

        private string Swap(string str, int i, int j)
        {
            var charArray = str.ToCharArray();
            var temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }
    }
}
