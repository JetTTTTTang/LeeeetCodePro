using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxProfit(prices));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }
            return maxProfit;
        }
    }
}
