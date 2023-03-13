using System;
using System.Collections.Generic;

namespace LeetCode_141._Linked_List_Cycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public class Solution
    {
        //public bool HasCycle(ListNode head)
        //{
        //    HashSet<ListNode> l = new HashSet<ListNode>();
        //    while(head != null)
        //    {
        //        if (!l.Contains(head))
        //            l.Add(head);
        //        else return true;
        //        head = head.next;
        //    }
        //    return false;
        //}
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            ListNode fast = head, slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                    return true;
            }

            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
