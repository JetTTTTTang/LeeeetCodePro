using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubdomainVisitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] cpdomains = new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
            foreach(var v in solution.SubdomainVisits(cpdomains))
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            List<string> result = new List<string>();
            Dictionary<string, int> timesDic = new Dictionary<string, int>();
            for(int i = 0; i < cpdomains.Length; i++)
            {
                string[] times = cpdomains[i].Split(' ');
                while (times[1].Contains('.'))
                {
                    if (timesDic.ContainsKey(times[1]))
                    {
                        timesDic[times[1]] += Convert.ToInt32(times[0]);
                    }
                    else
                    {
                        timesDic.Add(times[1], Convert.ToInt32(times[0]));
                    }

                    int index = times[1].IndexOf('.');
                    times[1] = times[1].Remove(0, index + 1);
                }

                if (timesDic.ContainsKey(times[1]))
                {
                    timesDic[times[1]] += Convert.ToInt32(times[0]);
                }
                else
                {
                    timesDic.Add(times[1], Convert.ToInt32(times[0]));
                }
            }

            foreach(var k in timesDic)
            {
                result.Add(k.Value + " " + k.Key);
            }
            return result;
        }
    }
}
