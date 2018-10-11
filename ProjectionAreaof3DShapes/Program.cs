using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionAreaof3DShapes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int ProjectionArea(int[][] grid)
        {
            int area1 = 0;
            int area2 = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                int max = 0;
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if (max < grid[i][j])
                    {
                        max = grid[i][j];
                    }

                    if (grid[i][j] != 0)
                    {
                        area1++;
                    }
                }
                area2 += max;
            }

            int area3 = 0;
            for(int i = 0; i < grid[0].Length; i++)
            {
                int max = 0;
                for(int j = 0; j < grid.Length; j++)
                {
                    if (max < grid[j][i])
                    {
                        max = grid[j][i];
                    }
                }
                area3 += max;
            }

            return area1 + area2 + area3;
        }
    }
}
