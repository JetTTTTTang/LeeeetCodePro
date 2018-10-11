using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTreePreorderTRaversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node5 = new Node(5, null);
            Node node6 = new Node(6, null);
            Node node3 = new Node(3, new List<Node> { node5, node6 });
            Node node2 = new Node(2, null);
            Node node4 = new Node(4, null);
            Node node1 = new Node(1, new List<Node> { node3, node2, node4 });
            Solution solution = new Solution();
            foreach (var v in solution.Preorder(node1))
            {
                Console.Write(v + " ");
            }
            Console.ReadKey();
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
        public IList<int> Preorder(Node root)
        {
            if (root == null) return new List<int>();

            Stack<Node> treeStack = new Stack<Node>();
            List<int> result = new List<int>();
            result.Add(root.val);
            Node node = root;
            while (treeStack.Count > 0 || (node.children != null && node.children.Count > 0))
            {
                if (node.children != null && node.children.Count > 0)
                {
                    treeStack.Push(node);
                    Node child = node.children[0];
                    node.children.RemoveAt(0);
                    result.Add(child.val);
                    node = child;
                }
                else
                {
                    node = treeStack.Pop();
                }
            }

            return result;
        }
    }
}
