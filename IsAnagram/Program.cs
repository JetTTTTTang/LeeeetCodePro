using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：有效的字母异位词
给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的一个字母异位词。

示例 1:

输入: s = "anagram", t = "nagaram"
输出: true
示例 2:

输入: s = "rat", t = "car"
输出: false
说明:
你可以假设字符串只包含小写字母。

进阶:
如果输入字符串包含 unicode 字符怎么办？你能否调整你的解法来应对这种情况？
*/

/*
Given two strings s and t , write a function to determine if t is an anagram of s.

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
Note:
You may assume the string contains only lowercase alphabets.

Follow up:
What if the inputs contain unicode characters? How would you adapt your solution to such case?
*/

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic[s[i]] = 1;
                }
            }

            for(int i = 0; i < t.Length; i++)
            {
                if (dic.ContainsKey(t[i])&&dic[t[i]]>0)
                {
                    dic[t[i]]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
