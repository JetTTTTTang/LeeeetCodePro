using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(121));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            char[] a = x.ToString().ToArray();
            char[] b = (char[])a.Clone();
            Array.Reverse(b);
            return new string(a) == new string(b);
        }
    }
}
