using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Solution solution = new Solution();
            solution.Rotate(nums, 0);
            foreach (var i in nums)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }

    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            if (k > nums.Length)
                k = k % nums.Length;
            if (k > nums.Length - 1)
                return;
            k = nums.Length - 1 - k;
            Array.Reverse(nums, 0, k + 1);
            Array.Reverse(nums, k + 1, nums.Length - k - 1);
            Array.Reverse(nums);
        }
    }
}
