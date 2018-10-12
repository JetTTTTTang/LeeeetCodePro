using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
