using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDepthofNTree
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;
        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public class Solution
    {
        List<int> result = new List<int>();

        public int MaxDepth(Node root)
        {
            if (root == null) return 0;
            int index = 0;
            ChildrenTree(root, index);
            result.Sort();
            return result[result.Count - 1];
        }

        private void ChildrenTree(Node node,int index)
        {
            index++;

            if (node.children != null && node.children.Count != 0)
            {
                foreach (Node i in node.children)
                {
                    ChildrenTree(i, index);
                }
            }
            else
            {
                result.Add(index);
            }
        }
    }
}
