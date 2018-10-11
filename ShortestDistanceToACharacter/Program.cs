using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestDistanceToACharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "loveleetcode";
            Solution solultion = new Solution();
            int[] a = solultion.ShortestToChar(s, 'e');
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] ShortestToChar(string S, char C)
        {
            string[] sSplit = S.Split(new char[] { C }, StringSplitOptions.None);
            List<int> result = new List<int>();
            for (int i = 0; i < sSplit.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < sSplit[i].Length; j++)
                    {
                        result.Add(sSplit[i].Length - j);
                    }
                    result.Add(0);
                }
                else if (i == sSplit.Length - 1)
                {
                    for (int j = 0; j < sSplit[i].Length; j++)
                    {
                        result.Add(j + 1);
                    }
                }
                else
                {
                    for (int j = 0; j < (sSplit[i].Length - 1) / 2 + 1 && sSplit[i].Length - 1 >= 0; j++)
                    {
                        result.Add(j + 1);
                    }
                    for (int j = (sSplit[i].Length + 1) / 2; j < sSplit[i].Length; j++)
                    {
                        result.Add(sSplit[i].Length - j);
                    }
                    result.Add(0);
                }
            }
            return result.ToArray();
        }
    }
}
