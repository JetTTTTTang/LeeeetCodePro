using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountainArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 1, 0 };
            Solution solution = new Solution();
            Console.WriteLine(solution.PeakIndexInMountainArray(A));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int PeakIndexInMountainArray(int [] A)
        {
            for(int i = 1; i < A.Length; i++)
            {
                if (A[i] < A[i - 1])
                {
                    return i - 1;
                }
            }
            return A.Length - 1;
        }
    }
}
