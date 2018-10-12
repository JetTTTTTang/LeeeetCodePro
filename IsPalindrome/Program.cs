using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：验证回文字符串
给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。

说明：本题中，我们将空字符串定义为有效的回文串。

示例 1:

输入: "A man, a plan, a canal: Panama"
输出: true
示例 2:

输入: "race a car"
输出: false
*/

/*
Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

Note: For the purpose of this problem, we define empty string as valid palindrome.

Example 1:

Input: "A man, a plan, a canal: Panama"
Output: true
Example 2:

Input: "race a car"
Output: false
*/

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "0P";
            Solution solution = new Solution();
            solution.IsPalindrome(s);
        }
    }

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int i = 0, j = s.Length - 1;
            for (; i < j;)
            {
                if (!Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                else if (!Char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }
                else if (s[i] != s[j])
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}
