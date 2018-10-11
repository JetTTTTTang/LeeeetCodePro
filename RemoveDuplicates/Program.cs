using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Solution solution = new Solution();
            solution.RemoveDuplicates(nums);
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;
            int number = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[number++] = nums[i];
                }
            }
            return number;
        }
    }
}
