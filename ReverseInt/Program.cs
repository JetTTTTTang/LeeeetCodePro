using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：颠倒整数
给定一个 32 位有符号整数，将整数中的数字进行反转。

示例 1:

输入: 123
输出: 321
 示例 2:

输入: -123
输出: -321
示例 3:

输入: 120
输出: 21
注意:

假设我们的环境只能存储 32 位有符号整数，其数值范围是 [−231,  231 − 1]。根据这个假设，如果反转后的整数溢出，则返回 0
*/

/*
Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
*/

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.MinValue;
            Solution solution = new Solution();
            Console.WriteLine(solution.Reverse(num));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            if (x == int.MinValue) return 0;

            bool isPositiveNum = x > 0;
            x = Math.Abs(x);

            StringBuilder sb = new StringBuilder();
            string num = x.ToString();

            for (int i = num.Length - 1; i >= 0; i--)
            {
                sb.Append(num[i]);
            }

            if ((isPositiveNum && Convert.ToInt64(sb.ToString()) > int.MaxValue)||(!isPositiveNum && Convert.ToInt64(sb.ToString()) > Math.Abs((long)int.MinValue)))
            {
                return 0;
            }
            else
            {
                return isPositiveNum ? Convert.ToInt32(sb.ToString()) : -Convert.ToInt32(sb.ToString());
            }
            
        }
    }
}
