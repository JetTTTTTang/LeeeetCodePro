using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：反转字符串
编写一个函数，其作用是将输入的字符串反转过来。

示例 1:

输入: "hello"
输出: "olleh"
示例 2:

输入: "A man, a plan, a canal: Panama"
输出: "amanaP :lanac a ,nalp a ,nam A"
 */

/*
Write a function that takes a string as input and returns the string reversed.

Example 1:

Input: "hello"
Output: "olleh"
Example 2:

Input: "A man, a plan, a canal: Panama"
Output: "amanaP :lanac a ,nalp a ,nam A"
*/

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            Solution solution = new Solution();
            solution.ReverseString(s);
        }
    }

    public class Solution
    {
        public string ReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
