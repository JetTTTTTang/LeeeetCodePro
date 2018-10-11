using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleofthLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int _val)
        {
            val = _val;
        }
    }

    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null) return null;
            List<ListNode> nodeList = new List<ListNode>();
            nodeList.Add(head);
            while(head.next != null)
            {
                head = head.next;
                nodeList.Add(head);
            }
            return nodeList[nodeList.Count / 2];
        }
    }
}
