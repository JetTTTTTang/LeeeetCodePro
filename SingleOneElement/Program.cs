using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOneElement
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach(var num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}
