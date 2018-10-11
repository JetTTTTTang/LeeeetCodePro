using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTreePostorderTraversal
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

        public IList<int> Postorder(Node root)
        {
            ChildrenTree(root);
            return result;
        }

        private void ChildrenTree(Node node)
        {
            if (node == null) return;

            if (node.children != null && node.children.Count != 0)
            {
                foreach(Node i in node.children)
                {
                    ChildrenTree(i);
                }
                result.Add(node.val);
            }
            else
            {
                result.Add(node.val);
            }
        }
    }
}
