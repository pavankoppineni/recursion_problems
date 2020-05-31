using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblems.PrintPyramid
{
    /// <summary>
    /// https://www.youtube.com/watch?v=ypyY1MDECfw
    /// </summary>
    public class PrintPyramidV1
    {
        private void Print(int height, IList<string> rows)
        {
            if (height == 0)
            {
                return;
            }

            Print(height - 1, rows);
            var builder = new StringBuilder();
            for (var i = 0; i < height; i++)
            {
                builder.Append("#");
            }
            rows.Add(builder.ToString());
        }

        public IList<string> Print(int height)
        {
            var rows = new List<string>();
            Print(height, rows);
            return rows;
        }
    }
}
