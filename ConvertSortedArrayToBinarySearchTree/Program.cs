using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSortedArrayToBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -10, -3, 0, 5, 9 };
            Solution solution = new Solution();
            TreeNode head = solution.SortedArrayToBST(nums);
            Console.ReadKey();
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            TreeNode head = new TreeNode(nums[nums.Length / 2]);
            TreeNode node = head;
            if (nums.Length > 0)
            {
                Sorted(node, nums);
            }
            return head;
        }

        private void Sorted(TreeNode node, int[] nums)
        {
            int[] nums1 = new int[nums.Length / 2];
            int[] nums2 = new int[(nums.Length - 1) / 2];
            Array.Copy(nums, 0, nums1, 0, nums.Length / 2);
            Array.Copy(nums, nums.Length / 2 + 1, nums2, 0, (nums.Length - 1) / 2);
            if (nums1.Length != 0)
            {
                node.left = new TreeNode(nums1[nums1.Length / 2]);
                Sorted(node.left, nums1);
            }

            if (nums2.Length != 0)
            {
                node.right = new TreeNode(nums2[nums2.Length / 2]);
                Sorted(node.right, nums2);
            }
        }
    }
}
