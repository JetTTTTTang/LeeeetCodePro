using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransposeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] A = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
            int[][] B = solution.Transpose(A);
            for (int i = 0; i < B.Length; i++)
            {
                for(int j = 0; j < B[i].Length; j++)
                {
                    Console.Write(B[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[][] Transpose(int[][] A)
        {
            int[][] B = new int[A[0].Length][];
            for(int i = 0; i < B.Length; i++)
            {
                B[i] = new int[A.Length];
            }

            for(int i = 0; i < A.Length; i++)
            {
                for(int j = 0; j < A[i].Length; j++)
                {
                    B[j][i] = A[i][j];
                }
            }
            return B;
        }
    }
}
