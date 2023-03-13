using System;

namespace LeetCode_206._Reverse_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            ListNode newHead = new ListNode(head.val);
            ListNode prev;
            while(head.next != null)
            {
                prev = newHead;
                newHead = new ListNode(head.next.val);
                newHead.next = prev;
                head = head.next;
            }

            return newHead;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3)));
            Solution s = new Solution(); s.ReverseList(head);
        }
    }
}
