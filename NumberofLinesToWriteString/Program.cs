using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberofLinesToWriteString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] widths = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            string S = "abcdefghijklmnopqrstuvwxyz";
            Solution solution = new Solution();
            Console.WriteLine(solution.NumberOfLines(widths, S));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            if (S == "" || S == null) return new int[] { 0, 0 };

            int[] result = new int[] { 1, 0 };
            foreach (var c in S)
            {
                result[1] += widths[c - 97];

                if (result[1] > 100)
                {
                    result[1] = widths[c - 97];
                    result[0]++;
                }
            }

            return result;
        }
    }
}
