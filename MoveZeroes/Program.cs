using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 题目：移动零
给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。

示例:

输入: [0,1,0,3,12]
输出: [1,3,12,0,0]
说明:

必须在原数组上操作，不能拷贝额外的数组。
尽量减少操作次数。
 */

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 2, 1 ,3,0,4,0,5,6,0 };
            solution.MoveZeroes(nums);
            foreach(var num in nums)
            {
                Console.Write(num);
            }
            Console.Read();
        }
    }

    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1) return;
            int zeroPosiont = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 &&zeroPosiont!=-1)
                {
                    nums[zeroPosiont] = nums[i];
                    nums[i] = 0;
                    zeroPosiont++;
                }
                else if(nums[i] == 0 && zeroPosiont == -1)
                {
                    zeroPosiont = i;
                }
            }
        }
    }
}
