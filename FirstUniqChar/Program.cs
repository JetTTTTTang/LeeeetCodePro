using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：字符串中的第一个唯一字符
给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。

案例:

s = "leetcode"
返回 0.

s = "loveleetcode",
返回 2.
 

注意事项：您可以假定该字符串只包含小写字母。
*/

/*
Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
Note: You may assume the string contain only lowercase letters.
*/

namespace FirstUniqChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "loveleetcode";
            Solution solution = new Solution();
            solution.FirstUniqChar(s);
        }
    }

    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            int[] nums = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                nums[s[i] - 'a']++;
            }

            for(int i = 0; i < s.Length; i++)
            {
                if(nums[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
