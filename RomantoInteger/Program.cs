using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomantoInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "MCMXCIV";
            Solution solution = new Solution();
            Console.WriteLine(solution.RomanToInt(s));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        //字典
        private static int[] _dict = new[]
        {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            100,
            500,
            0,
            0,
            0,
            0,
            1,
            0,
            0,
            50,
            1000,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            5,
            0,
            10
        };
        public int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            var hasVal = true;
            var upVal = _dict[s[0]];
            var sumVal = 0;
            for (int i = 1; i < s.Length; i++)
            {
                var val = _dict[s[i]];
                if (hasVal)
                {
                    if (upVal < val)
                    {
                        sumVal += val - upVal;
                        hasVal = false;
                    }
                    else
                    {
                        sumVal += upVal;
                        upVal = val;
                    }
                }
                else
                {
                    upVal = val;
                    hasVal = true;
                }
            }
            if (hasVal) sumVal += upVal;
            return sumVal;
        }
    }
}
