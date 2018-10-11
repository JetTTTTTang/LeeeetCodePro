using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            Solution solution = new Solution();
            Console.WriteLine(solution.ContainsDuplicate(nums));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1)
                return false;
            Array.Sort(nums);
            for(int i = 1;i<nums.Length;i++)
            {
                if (nums[i] == nums[i - 1])
                    return true;
            }
            return false;
        }
    }
}
