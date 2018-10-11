using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.Generate(5);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            if (numRows == 0) return new List<IList<int>>();

            List<int> row = new List<int>();
            row.Add(1);
            List<IList<int>> result = new List<IList<int>>();
            result.Add(row);
            for (int i = 2; i <= numRows; i++)
            {
                row = new List<int>();
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1)
                        row.Add(1);
                    else if (j == i)
                        row.Add(1);
                    else
                        row.Add(result[i - 2][j - 2] + result[i - 2][j - 1]);
                }

                result.Add(row);
            }

            return result;
        }
    }
}
