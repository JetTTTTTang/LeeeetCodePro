using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  报数
报数序列是一个整数序列，按照其中的整数的顺序进行报数，得到下一个数。其前五项如下：

1.     1
2.     11
3.     21
4.     1211
5.     111221
1 被读作  "one 1"  ("一个一") , 即 11。
11 被读作 "two 1s" ("两个一"）, 即 21。
21 被读作 "one 2",  "one 1" （"一个二" ,  "一个一") , 即 1211。

给定一个正整数 n（1 ≤ n ≤ 30），输出报数序列的第 n 项。

注意：整数顺序将表示为一个字符串。

 

示例 1:

输入: 1
输出: "1"
示例 2:

输入: 4
输出: "1211"
*/

/*
The count-and-say sequence is the sequence of integers with the first five terms as following:

1.     1
2.     11
3.     21
4.     1211
5.     111221
1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.

Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence.

Note: Each term of the sequence of integers will be represented as a string.

 

Example 1:

Input: 1
Output: "1"
Example 2:

Input: 4
Output: "1211"
*/

namespace CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Solution solution = new Solution();
            solution.CountAndSay(n);
        }
    }

    public class Solution
    {
        public string CountAndSay(int n)
        {
            string lastStr = "1";
            StringBuilder result = new StringBuilder();
            result.AppendLine(lastStr);
            for (int i = n; i > 1; i--)
            {
                result.Clear();
                for (int j = 1, position = 0; j <= lastStr.Length; j++)
                {
                    if (j == lastStr.Length || lastStr[j - 1] != lastStr[j])
                    {
                        result.Append(j - position);
                        result.Append(lastStr[j - 1]);
                        position = j;
                    }
                }
                lastStr = result.ToString();
            }
            return lastStr;
        }
    }
}
