using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueMorseCodeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = { "gin", "zen", "gig", "msg" };
            Solution solution = new Solution();
            Console.WriteLine(solution.UniqueMorseRepresentations(word));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        private readonly string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        public int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<string, int> translateDic = new Dictionary<string, int>();
            foreach(var word in words)
            {
                StringBuilder translate = new StringBuilder();
                for(int i = 0; i < word.Length; i++)
                {
                    translate.Append(morse[word[i] - 97]);
                }

                if(translateDic.ContainsKey(translate.ToString()))
                {
                    translateDic[translate.ToString()]++;
                }
                else
                {
                    translateDic.Add(translate.ToString(), 1);
                }
            }

            return translateDic.Count;
        }
        
    }
}
