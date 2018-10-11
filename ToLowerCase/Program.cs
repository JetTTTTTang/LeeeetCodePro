using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.ToLowerCase("PiTAs"));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            for(int i = 0; i < sb.Length; i++)
            {
                if (sb[i] >= 'A' && sb[i] <= 'Z')
                {
                    sb[i] = (char)(Convert.ToInt32(sb[i]) + 32);
                }
            }
            return sb.ToString();
        }
    }
}
