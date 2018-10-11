using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1 ,2};
            int[] nums2 = new int[] {1,1};
            Solution solution = new Solution();
            solution.Intersect(nums1, nums2);
        }
    }

    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0) return new int[] { };
            List<int> nums3 = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0, j = 0;
            for (; i < nums1.Length;)
            {
                for (; j < nums2.Length;)
                {
                    if (nums1[i] == nums2[j])
                    {
                        nums3.Add(nums1[i]);
                        i++;
                        j++;
                        break;
                    }
                    else if (nums1[i] > nums2[j])
                    {
                        j++;
                        break;
                    }
                    else
                    {
                        i++;
                        break;
                    }
                }
                if (j >= nums2.Length) break;
            }
            return nums3.ToArray();
        }
    }
}
