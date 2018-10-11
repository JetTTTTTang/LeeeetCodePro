using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.BinaryGap(8));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int BinaryGap(int N)
        {
            int distance = 1;
            int result = 0;
            string binary = Convert.ToString(N, 2);
            for(int i = 1; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    distance++;
                }
                else
                {
                    if (distance > result)
                    {
                        result = distance;
                    }
                    distance = 1;
                }
            }
            return result;
        }
    }
}
