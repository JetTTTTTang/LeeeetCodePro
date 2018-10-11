using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 题目：加一
给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。

最高位数字存放在数组的首位， 数组中每个元素只存储一个数字。

你可以假设除了整数 0 之外，这个整数不会以零开头。

示例 1:

输入: [1,2,3]
输出: [1,2,4]
解释: 输入数组表示数字 123。
示例 2:

输入: [4,3,2,1]
输出: [4,3,2,2]
解释: 输入数组表示数字 4321。
*/

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            Solution solution = new Solution();
            solution.PlusOne(a);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] + 1 < 10)
                {
                    digits[i]++;
                    break;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            if(digits[0] == 0)
            {
                Array.Resize(ref digits, digits.Length + 1);
                digits[digits.Length - 1] = 1;
                Array.Reverse(digits);
            }
            return digits;
        }
    }
}
