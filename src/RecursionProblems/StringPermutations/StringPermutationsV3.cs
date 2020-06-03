using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RecursionProblems.StringPermutations
{
    /// <summary>
    /// https://www.youtube.com/watch?v=nYFd7VHKyWQ
    /// </summary>
    public class StringPermutationsV3
    {
        public IList<string> GeneratePermutations(string str)
        {
            var permutations = new List<string>();
            var countDict = new Dictionary<char, int>();
            foreach(var item in str)
            {
                if (countDict.ContainsKey(item))
                {
                    countDict[item]++;
                }
                else
                {
                    countDict.Add(item, 1);
                }
            }

            var resultArray = new char[str.Length];
            GeneratePermutations(countDict, countDict.Keys.ToArray(), resultArray, 0, permutations);
            return permutations;
        }

        private void GeneratePermutations(IDictionary<char, int> countDict, char[] keys, char[] resultArray, int level, IList<string> permutations)
        {
            if(level == resultArray.Length)
            {
                permutations.Add(new string(resultArray));
                return;
            }

            foreach (var key in keys)
            {
                if (countDict[key] == 0)
                {
                    continue;
                }

                resultArray[level] = key;
                countDict[key]--;
                GeneratePermutations(countDict, keys, resultArray, level + 1, permutations);
                countDict[key]++;
            }
        }
    }
}
