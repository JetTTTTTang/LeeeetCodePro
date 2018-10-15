using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：最长公共前缀
编写一个函数来查找字符串数组中的最长公共前缀。

如果不存在公共前缀，返回空字符串 ""。

示例 1:

输入: ["flower","flow","flight"]
输出: "fl"
示例 2:

输入: ["dog","racecar","car"]
输出: ""
解释: 输入不存在公共前缀。
说明:

所有输入只包含小写字母 a-z 。
*/

/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
Note:

All given inputs are in lowercase letters a-z.
*/

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "" };
            Solution solution = new Solution();
            solution.LongestCommonPrefix(strs);
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];
            if (strs.Length == 0 || strs == null) return "";

            StringBuilder sb = new StringBuilder();
            while (true)
            {
                char a = 'A';
                for (int i = 0; i < strs.Length; i++)
                {
                    if (sb.Length >= strs[i].Length || (a != 'A' && strs[i][sb.Length] != a))
                    {
                        return sb.ToString();
                    }
                    else if (a == 'A')
                    {
                        a = strs[i][sb.Length];
                    }
                }
                sb.Append(a);
            }
        }
    }
}
