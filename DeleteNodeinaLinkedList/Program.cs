using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNodeinaLinkedList
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
        public ListNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        public void DeleteNode(ListNode head,int node)
        {
            ListNode newNode = head;
            if (head.val == node)
            {
                head = head.next;
                return;
            }
            else
            {
                newNode = head.next;
            }

            while (true)
            {
                if(newNode.val == node)
                {
                    head.next = newNode.next;
                    return;
                }
                else
                {
                    newNode = newNode.next;
                }
            }
        }
    }
}
