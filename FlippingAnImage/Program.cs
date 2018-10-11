using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingAnImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] a = { new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } };
            int[][] b = solution.FlipAndInvertImage(a);
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length / 2 + A[i].Length % 2; j++)
                {
                    if (A[i][j] == A[i][A[i].Length - j - 1])
                    {
                        A[i][j] = A[i][j] == 0 ? 1 : 0;
                        A[i][A[i].Length - j - 1] = A[i][j];
                    }
                }
            }

            return A;
        }
    }
}
